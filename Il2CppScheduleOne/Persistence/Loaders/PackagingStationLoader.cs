using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200024E RID: 590
	public class PackagingStationLoader : GridItemLoader
	{
		// Token: 0x06002E6F RID: 11887 RVA: 0x00104808 File Offset: 0x00102A08
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationLoader()
		{
			Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PackagingStationLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr);
			PackagingStationLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr, 100668682);
			PackagingStationLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr, 100668683);
			PackagingStationLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr, 100668684);
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x00104874 File Offset: 0x00102A74
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129793, XrefRangeEnd = 129800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x001048B8 File Offset: 0x00102AB8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x001048F4 File Offset: 0x00102AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129800, XrefRangeEnd = 129868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00018997 File Offset: 0x00016B97
		public PackagingStationLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x0200090F RID: 2319
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PackagingStationLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C5DD RID: 50653 RVA: 0x00301870 File Offset: 0x002FFA70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingStationLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr);
				PackagingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, "station");
				PackagingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				PackagingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668685);
				PackagingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668686);
			}

			// Token: 0x0600C5DE RID: 50654 RVA: 0x003018EC File Offset: 0x002FFAEC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5DF RID: 50655 RVA: 0x00301928 File Offset: 0x002FFB28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129777, XrefRangeEnd = 129793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5E0 RID: 50656 RVA: 0x000604D4 File Offset: 0x0005E6D4
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DB0 RID: 15792
			// (get) Token: 0x0600C5E1 RID: 50657 RVA: 0x0030195C File Offset: 0x002FFB5C
			// (set) Token: 0x0600C5E2 RID: 50658 RVA: 0x000604DD File Offset: 0x0005E6DD
			public unsafe PackagingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DB1 RID: 15793
			// (get) Token: 0x0600C5E3 RID: 50659 RVA: 0x0030198C File Offset: 0x002FFB8C
			// (set) Token: 0x0600C5E4 RID: 50660 RVA: 0x000604FC File Offset: 0x0005E6FC
			public unsafe PackagingStationConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008603 RID: 34307
			private static readonly IntPtr NativeFieldInfoPtr_station;

			// Token: 0x04008604 RID: 34308
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008605 RID: 34309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008606 RID: 34310
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
