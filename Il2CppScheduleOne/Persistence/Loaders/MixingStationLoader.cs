using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200024D RID: 589
	public class MixingStationLoader : GridItemLoader
	{
		// Token: 0x06002E6A RID: 11882 RVA: 0x001046CC File Offset: 0x001028CC
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationLoader()
		{
			Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "MixingStationLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr);
			MixingStationLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr, 100668677);
			MixingStationLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr, 100668678);
			MixingStationLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr, 100668679);
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00104738 File Offset: 0x00102938
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129702, XrefRangeEnd = 129709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x0010477C File Offset: 0x0010297C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x001047B8 File Offset: 0x001029B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129709, XrefRangeEnd = 129777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x0001898E File Offset: 0x00016B8E
		public MixingStationLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x0200090E RID: 2318
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.MixingStationLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C5D5 RID: 50645 RVA: 0x00301724 File Offset: 0x002FF924
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixingStationLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr);
				MixingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, "station");
				MixingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				MixingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668680);
				MixingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668681);
			}

			// Token: 0x0600C5D6 RID: 50646 RVA: 0x003017A0 File Offset: 0x002FF9A0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5D7 RID: 50647 RVA: 0x003017DC File Offset: 0x002FF9DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129683, XrefRangeEnd = 129702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5D8 RID: 50648 RVA: 0x0006048D File Offset: 0x0005E68D
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DAE RID: 15790
			// (get) Token: 0x0600C5D9 RID: 50649 RVA: 0x00301810 File Offset: 0x002FFA10
			// (set) Token: 0x0600C5DA RID: 50650 RVA: 0x00060496 File Offset: 0x0005E696
			public unsafe MixingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DAF RID: 15791
			// (get) Token: 0x0600C5DB RID: 50651 RVA: 0x00301840 File Offset: 0x002FFA40
			// (set) Token: 0x0600C5DC RID: 50652 RVA: 0x000604B5 File Offset: 0x0005E6B5
			public unsafe MixingStationConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStationConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085FF RID: 34303
			private static readonly IntPtr NativeFieldInfoPtr_station;

			// Token: 0x04008600 RID: 34304
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008601 RID: 34305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008602 RID: 34306
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
