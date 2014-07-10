﻿using System;

namespace Ubertesters.Bindings
{
	public interface ILogger
	{
		void Info(string message);
		void Warn(string message);
		void Error(string message);
	}
}
