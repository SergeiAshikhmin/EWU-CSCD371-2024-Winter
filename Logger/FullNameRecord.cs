using System;

namespace Logger;

public readonly record struct FullNameRecord(string First, string Last, string? Middle = null);