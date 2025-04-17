using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000449 RID: 1097
	[Serializable]
	public class VocalReactionDatabase : Object
	{
		// Token: 0x06005F99 RID: 24473 RVA: 0x001B6BD0 File Offset: 0x001B4DD0
		// Note: this type is marked as 'beforefieldinit'.
		static VocalReactionDatabase()
		{
			Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "VocalReactionDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr);
			VocalReactionDatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entries");
			VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100675494);
			VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100675495);
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x001B6C3C File Offset: 0x001B4E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198510, XrefRangeEnd = 198521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase.Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VocalReactionDatabase.Entry>(intPtr3) : null;
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x001B6C8C File Offset: 0x001B4E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198521, XrefRangeEnd = 198529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x0002D199 File Offset: 0x0002B399
		public VocalReactionDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x001B6CC8 File Offset: 0x001B4EC8
		// (set) Token: 0x06005F9E RID: 24478 RVA: 0x0002D1A2 File Offset: 0x0002B3A2
		public unsafe List<VocalReactionDatabase.Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VocalReactionDatabase.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004157 RID: 16727
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004158 RID: 16728
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04004159 RID: 16729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A0D RID: 2573
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600CE9A RID: 52890 RVA: 0x0031AEF0 File Offset: 0x003190F0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr);
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Key");
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Reactions");
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675496);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675497);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675498);
			}

			// Token: 0x17004041 RID: 16449
			// (get) Token: 0x0600CE9B RID: 52891 RVA: 0x0031AF80 File Offset: 0x00319180
			public unsafe string name
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600CE9C RID: 52892 RVA: 0x0031AFB8 File Offset: 0x003191B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198509, XrefRangeEnd = 198510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetRandomReaction()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CE9D RID: 52893 RVA: 0x0031AFF0 File Offset: 0x003191F0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE9E RID: 52894 RVA: 0x000647A3 File Offset: 0x000629A3
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403F RID: 16447
			// (get) Token: 0x0600CE9F RID: 52895 RVA: 0x0031B02C File Offset: 0x0031922C
			// (set) Token: 0x0600CEA0 RID: 52896 RVA: 0x000647AC File Offset: 0x000629AC
			public unsafe string Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004040 RID: 16448
			// (get) Token: 0x0600CEA1 RID: 52897 RVA: 0x0031B054 File Offset: 0x00319254
			// (set) Token: 0x0600CEA2 RID: 52898 RVA: 0x000647CB File Offset: 0x000629CB
			public unsafe Il2CppStringArray Reactions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B6D RID: 35693
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x04008B6E RID: 35694
			private static readonly IntPtr NativeFieldInfoPtr_Reactions;

			// Token: 0x04008B6F RID: 35695
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04008B70 RID: 35696
			private static readonly IntPtr NativeMethodInfoPtr_GetRandomReaction_Public_String_0;

			// Token: 0x04008B71 RID: 35697
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
