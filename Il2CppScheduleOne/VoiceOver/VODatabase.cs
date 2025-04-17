using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x02000170 RID: 368
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06001D97 RID: 7575 RVA: 0x000CC6BC File Offset: 0x000CA8BC
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabase()
		{
			Il2CppClassPointerStore<VODatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabase>.NativeClassPtr);
			VODatabase.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "VolumeMultiplier");
			VODatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "Entries");
			VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666665);
			VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666666);
			VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666667);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000CC750 File Offset: 0x000CA950
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106153, RefRangeEnd = 106156, XrefRangeStart = 106143, XrefRangeEnd = 106153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VODatabaseEntry>(intPtr3) : null;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x000CC79C File Offset: 0x000CA99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106156, XrefRangeEnd = 106157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000CC7E8 File Offset: 0x000CA9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106157, XrefRangeEnd = 106165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00010B79 File Offset: 0x0000ED79
		public VODatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000CC824 File Offset: 0x000CAA24
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x00010B82 File Offset: 0x0000ED82
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000CC84C File Offset: 0x000CAA4C
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00010B9D File Offset: 0x0000ED9D
		public unsafe List<VODatabaseEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VODatabaseEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
