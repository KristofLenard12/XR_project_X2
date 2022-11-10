// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403 : ICoherenceComponentData
	{
		public bool convex;
		public float skinWidth;
		public bool inflateMesh;
		public bool enabled;
		public bool isTrigger;
		public float contactOffset;
		public bool hasModifiableContacts;

		public override string ToString()
		{
			return $"AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403(convex: {convex}, skinWidth: {skinWidth}, inflateMesh: {inflateMesh}, enabled: {enabled}, isTrigger: {isTrigger}, contactOffset: {contactOffset}, hasModifiableContacts: {hasModifiableContacts})";
		}

		public uint GetComponentType() => Definition.InternalAirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;

		private static readonly float _skinWidth_Epsilon = 2.3283064365386963e-10f;
		private static readonly float _contactOffset_Epsilon = 2.3283064365386963e-10f;

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				convex = other.convex;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				skinWidth = other.skinWidth;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				inflateMesh = other.inflateMesh;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				enabled = other.enabled;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				isTrigger = other.isTrigger;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				contactOffset = other.contactOffset;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				hasModifiableContacts = other.hasModifiableContacts;
			}
			mask >>= 1;
			return this;
		}

		public uint DiffWith(ICoherenceComponentData data)
		{
			uint mask = 0;
			var newData = (AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403)data;

			if (convex != newData.convex) {
				mask |= 0b00000000000000000000000000000001;
			}
			if (skinWidth.DiffersFrom(newData.skinWidth, _skinWidth_Epsilon)) {
				mask |= 0b00000000000000000000000000000010;
			}
			if (inflateMesh != newData.inflateMesh) {
				mask |= 0b00000000000000000000000000000100;
			}
			if (enabled != newData.enabled) {
				mask |= 0b00000000000000000000000000001000;
			}
			if (isTrigger != newData.isTrigger) {
				mask |= 0b00000000000000000000000000010000;
			}
			if (contactOffset.DiffersFrom(newData.contactOffset, _contactOffset_Epsilon)) {
				mask |= 0b00000000000000000000000000100000;
			}
			if (hasModifiableContacts != newData.hasModifiableContacts) {
				mask |= 0b00000000000000000000000001000000;
			}

			return mask;
		}

		public static void Serialize(AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.convex);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteFloat(data.skinWidth, FloatMeta.NoCompression());
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.inflateMesh);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.enabled);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.isTrigger);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteFloat(data.contactOffset, FloatMeta.NoCompression());
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.hasModifiableContacts);
			}
			mask >>= 1;
		}

		public static (AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403();
			if (bitStream.ReadMask())
			{
				val.convex = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.skinWidth = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.inflateMesh = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000100;
			}
			if (bitStream.ReadMask())
			{
				val.enabled = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000001000;
			}
			if (bitStream.ReadMask())
			{
				val.isTrigger = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000010000;
			}
			if (bitStream.ReadMask())
			{
				val.contactOffset = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000100000;
			}
			if (bitStream.ReadMask())
			{
				val.hasModifiableContacts = bitStream.ReadBool();
				mask |= 0b00000000000000000000000001000000;
			}
			return (val, mask, null);
		}

		public static (AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403, uint, uint?) DeserializeArchetypeAirHockeyTable_1b8979aab75cc3548ac0742146ec7eed_AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403();
			if (bitStream.ReadMask())
			{
				val.convex = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.skinWidth = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.inflateMesh = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000100;
			}
			if (bitStream.ReadMask())
			{
				val.enabled = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000001000;
			}
			if (bitStream.ReadMask())
			{
				val.isTrigger = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000010000;
			}
			if (bitStream.ReadMask())
			{
				val.contactOffset = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000100000;
			}
			if (bitStream.ReadMask())
			{
				val.hasModifiableContacts = bitStream.ReadBool();
				mask |= 0b00000000000000000000000001000000;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as AirHockeyTable_id1_UnityEngine__char_46_MeshCollider_8131950279819150403?;
		}
	}
}