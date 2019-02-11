using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* Project: OOSD Threaded Project 2
* Connection String class to establish connection
* Author: Hayden Belanger
* Date: Jan 2019
* Commenter: Eugenia Chiu and Hayden Belanger
*/

namespace DBClasses
{
    [Serializable]
    public class ConnectionString
    {

		/// <summary>
		/// Access to the successful Connection object. Any attempts to reference this before the client successfully connects
		/// will be met with failure.
		/// </summary>
		public static ConnectionString Connection = null;

		//Internal string used to store the raw ConnectionString as it must be stored normally in a non-readonly object.
        private readonly string _cs = null;

		/// <summary>
		/// Constructor used to build the globally accessible Connection String object. Upon successful construction,
		/// this will be written to the Connection public variable in this class.
		/// </summary>
		/// <param name="ConnectionString">The raw Connection String, as passed from <see cref="SqlConnectionStringBuilder"/>.</param>
        public ConnectionString(string ConnectionString)
        {

            this._cs = ConnectionString;
        }

        public string Value()
        {
            return _cs;
        }
    }
}
