using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000244 RID: 580
	public class PackagerLoader : EmployeeLoader
	{
		// Token: 0x06002E3A RID: 11834 RVA: 0x00103A88 File Offset: 0x00101C88
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerLoader()
		{
			Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PackagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr);
			PackagerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, 100668632);
			PackagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, 100668633);
			PackagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, 100668634);
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00103AF4 File Offset: 0x00101CF4
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128922, XrefRangeEnd = 128929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00103B38 File Offset: 0x00101D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00103B74 File Offset: 0x00101D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128929, XrefRangeEnd = 129010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x0001893D File Offset: 0x00016B3D
		public PackagerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000905 RID: 2309
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PackagerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C597 RID: 50583 RVA: 0x00300CFC File Offset: 0x002FEEFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, "packager");
				PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668635);
			}

			// Token: 0x0600C598 RID: 50584 RVA: 0x00300D50 File Offset: 0x002FEF50
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C599 RID: 50585 RVA: 0x00060274 File Offset: 0x0005E474
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D9F RID: 15775
			// (get) Token: 0x0600C59A RID: 50586 RVA: 0x00300D8C File Offset: 0x002FEF8C
			// (set) Token: 0x0600C59B RID: 50587 RVA: 0x0006027D File Offset: 0x0005E47D
			public unsafe Packager packager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_packager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085E0 RID: 34272
			private static readonly IntPtr NativeFieldInfoPtr_packager;

			// Token: 0x040085E1 RID: 34273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000906 RID: 2310
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PackagerLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x0600C59C RID: 50588 RVA: 0x00300DBC File Offset: 0x002FEFBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr);
				PackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				PackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				PackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668636);
				PackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668637);
			}

			// Token: 0x0600C59D RID: 50589 RVA: 0x00300E38 File Offset: 0x002FF038
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C59E RID: 50590 RVA: 0x00300E74 File Offset: 0x002FF074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128891, XrefRangeEnd = 128909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C59F RID: 50591 RVA: 0x0006029C File Offset: 0x0005E49C
			public __c__DisplayClass3_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DA0 RID: 15776
			// (get) Token: 0x0600C5A0 RID: 50592 RVA: 0x00300EA8 File Offset: 0x002FF0A8
			// (set) Token: 0x0600C5A1 RID: 50593 RVA: 0x000602A5 File Offset: 0x0005E4A5
			public unsafe PackagerConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DA1 RID: 15777
			// (get) Token: 0x0600C5A2 RID: 50594 RVA: 0x00300ED8 File Offset: 0x002FF0D8
			// (set) Token: 0x0600C5A3 RID: 50595 RVA: 0x000602C4 File Offset: 0x0005E4C4
			public unsafe PackagerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085E2 RID: 34274
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x040085E3 RID: 34275
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085E4 RID: 34276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085E5 RID: 34277
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000907 RID: 2311
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PackagerLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Object
		{
			// Token: 0x0600C5A4 RID: 50596 RVA: 0x00300F08 File Offset: 0x002FF108
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagerLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr);
				PackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				PackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				PackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668638);
				PackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668639);
			}

			// Token: 0x0600C5A5 RID: 50597 RVA: 0x00300F84 File Offset: 0x002FF184
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5A6 RID: 50598 RVA: 0x00300FC0 File Offset: 0x002FF1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128909, XrefRangeEnd = 128922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5A7 RID: 50599 RVA: 0x000602E3 File Offset: 0x0005E4E3
			public __c__DisplayClass3_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DA2 RID: 15778
			// (get) Token: 0x0600C5A8 RID: 50600 RVA: 0x00300FF4 File Offset: 0x002FF1F4
			// (set) Token: 0x0600C5A9 RID: 50601 RVA: 0x000602EC File Offset: 0x0005E4EC
			public unsafe PackagerData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DA3 RID: 15779
			// (get) Token: 0x0600C5AA RID: 50602 RVA: 0x00301024 File Offset: 0x002FF224
			// (set) Token: 0x0600C5AB RID: 50603 RVA: 0x0006030B File Offset: 0x0005E50B
			public unsafe PackagerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085E6 RID: 34278
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040085E7 RID: 34279
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085E8 RID: 34280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085E9 RID: 34281
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
