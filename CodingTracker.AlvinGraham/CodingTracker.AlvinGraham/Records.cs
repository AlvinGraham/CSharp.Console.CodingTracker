﻿namespace CodingTracker;

internal class CodingRecord
{
	internal int Id { get; set; }
	internal DateTime DateStart { get; set; }
	internal DateTime DateEnd { get; set; }
	internal TimeSpan Duration { get; set; }
}

internal class GoalRecord
{
	internal int Id { get; set; }
	internal int TotalMinutes { get; set; }
	internal DateTime DateEnd { get; set; }

}
