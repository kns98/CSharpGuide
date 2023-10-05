﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.Multimedia;

namespace MidiSorcery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MidiSorcery!");

            Console.Write("Enter the path to your MIDI file: ");
            string location = Console.ReadLine();

            SongPlayer.Initialize(location);

            SongPlayer.OnNotePlayed += () => Console.WriteLine("Note Played.");
            SongPlayer.OnFinish += () => Console.WriteLine("Song Finished.");

            bool shouldContinue = true;
            while (shouldContinue)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Pause");
                Console.WriteLine("3. Search by position");
                Console.WriteLine("4. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        SongPlayer.Play();
                        break;

                    case "2":
                        SongPlayer.Pause();
                        break;

                    case "3":
                        Console.Write("Enter position: ");
                        int position;
                        if (int.TryParse(Console.ReadLine(), out position))
                        {
                            SongPlayer.Search(position);
                        }
                        else
                        {
                            Console.WriteLine("Invalid position.");
                        }
                        break;

                    case "4":
                        SongPlayer.Exit();
                        shouldContinue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }


        public static class SongPlayer
        {
            private static OutputDevice outputDevice;
            private static Playback playback;


            public static event Action OnNotePlayed;
            public static event Action OnFinish;


            public static int Elapsed => int.Parse(playback.GetCurrentTime(TimeSpanType.Midi).ToString());
            public static int Duration => int.Parse(playback.GetDuration(TimeSpanType.Midi).ToString());

            public static MetricTimeSpan ElaspedSpan => (MetricTimeSpan)playback.GetCurrentTime(TimeSpanType.Metric);
            public static MetricTimeSpan DurationSpan => (MetricTimeSpan)playback.GetDuration(TimeSpanType.Metric);
            public static bool IsRunning => playback.IsRunning;


            public static void Initialize(string location)
            {
                outputDevice = OutputDevice.GetByName(CheckSynth());

                try
                {
                    var midiFile = MidiFile.Read(location);

                    playback = midiFile.GetPlayback(outputDevice);
                    playback.NotesPlaybackStarted += Playback_NotesPlaybackStarted;
                    playback.Finished += Playback_Finished;
                    playback.InterruptNotesOnStop = true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            private static void Playback_Finished(object? sender, EventArgs e)
            {
                OnFinish?.Invoke();
            }

            private static void Playback_NotesPlaybackStarted(object? sender, NotesEventArgs e)
            {
                OnNotePlayed?.Invoke();
            }

            public static void Play()
            {
                if (playback == null)
                    return;

                playback.Start();
            }
            public static void Pause()
            {
                if (playback == null)
                    return;

                playback.Stop();
            }

            public static void Search(int position)
            {
                if (playback == null)
                    return;

                Pause();
                MidiTimeSpan span = new MidiTimeSpan(position);
                playback.MoveToTime(span);

                Play();
            }

            static string CheckSynth()
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string specificFolder = Path.Combine(path, "MidiSorcery");
                string filePath = Path.Combine(specificFolder, "Synth.option");

                if (File.Exists(filePath))
                {
                    string[] info = File.ReadAllLines(filePath);

                    string synth = "Microsoft GS WaveTable Synth";
                    foreach (string s in info)
                    {
                        if (s.StartsWith('#'))
                            continue;

                        synth = s;
                        break;
                    }

                    return synth;
                }
                else
                {
                    Directory.CreateDirectory(specificFolder);

                    List<OutputDevice> devices = OutputDevice.GetAll().ToList();
                    List<string> fileLines = new List<string>();


                    fileLines.Add("# Lines with '#' are ignored, use this to select preferred output device");
                    for (int i = 0; i < devices.Count; i++)
                    {
                        if (i == 0)
                        {
                            fileLines.Add(devices[i].Name);
                            continue;
                        }

                        fileLines.Add("# " + devices[i].Name);

                    }


                    File.WriteAllLines(filePath, fileLines);
                    return devices[0].Name;
                }
            }

            public static void Exit()
            {

                if (outputDevice == null || playback == null)
                    return;

                outputDevice.Dispose();
                playback.Dispose();

                outputDevice = null;
                playback = null;
            }
        }
    }

