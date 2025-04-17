using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x02000171 RID: 369
	[Serializable]
	public class VODatabaseEntry : Il2CppSystem.Object
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x000CC87C File Offset: 0x000CAA7C
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabaseEntry()
		{
			Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabaseEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr);
			VODatabaseEntry.NativeFieldInfoPtr_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "LineType");
			VODatabaseEntry.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "Clips");
			VODatabaseEntry.NativeFieldInfoPtr_lastClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "lastClip");
			VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "VolumeMultiplier");
			VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100666668);
			VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100666669);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000CC924 File Offset: 0x000CAB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106165, XrefRangeEnd = 106173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000CC964 File Offset: 0x000CAB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106173, XrefRangeEnd = 106174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00010BBC File Offset: 0x0000EDBC
		public VODatabaseEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000CC9A0 File Offset: 0x000CABA0
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00010BC5 File Offset: 0x0000EDC5
		public unsafe EVOLineType LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType)) = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000CC9C8 File Offset: 0x000CABC8
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x000CC9F8 File Offset: 0x000CABF8
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x00010BFF File Offset: 0x0000EDFF
		public unsafe AudioClip lastClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x000CCA28 File Offset: 0x000CAC28
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00010C1E File Offset: 0x0000EE1E
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeFieldInfoPtr_LineType;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_lastClip;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
