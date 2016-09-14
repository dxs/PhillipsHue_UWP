using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PhillipsHue_UWP.HueLib
{
	/// <summary>
	/// Represents a Hue Group
	/// </summary>
	/// <remarks>http://www.developers.meethue.com/documentation/groups-api</remarks>
	[DataContract]
	class Groups
	{
		/// <summary>
		/// An internal backlink to the group's bridge
		/// </summary>
		internal Bridge _bridge;

		/// <summary>
		/// Gets or sets the group's id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the group's name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the group's lights
		/// </summary>
		[DataMember(Name = "lights")]
		public string[] Lights { get; set; }

		/// <summary>
		/// Gets or sets the group's type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the group's action
		/// </summary>
		[DataMember(Name = "action")]
		public Action Action { get; set; }
	}

	[DataContract]
	public class Action
	{
		/// <summary>
		/// An internal backlink to this state's group
		/// </summary>
		internal Groups _groups;

		//[DataMember(Name = "on")]
		/*Todo*/
	}
}
