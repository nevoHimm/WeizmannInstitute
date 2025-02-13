﻿/**************************************************************************
Gmail Agent API
Copyright (C) 2005 Johnvey Hwang, Eric Larson
http://sourceforge.net/projects/gmail-api/

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
**************************************************************************/

using System;
using System.Collections;

namespace Johnvey.GmailAgent
{
	/// <summary>
	/// Represents a collection of <see cref="GmailFilter"/> objects.
	/// </summary>
    // Added by Eric Larson [larson.eric@gmail.com]; 5/2/2005
    public class GmailFilterCollection : ArrayList
	{
		/// <summary>
		/// Initializes a new instance of the GmailFilterCollection class.
		/// </summary>
		/// <remarks>
		/// This class currently inherits ArrayList, and therefore is not strongly typed.  Ideally it should implement <see cref="IList"/> instead and return <see cref="GmailFilter"/>'s only.
		/// </remarks>
		public GmailFilterCollection()
		{

		}
	}
}
