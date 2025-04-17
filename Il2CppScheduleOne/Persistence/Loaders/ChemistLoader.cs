using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000240 RID: 576
	public class ChemistLoader : EmployeeLoader
	{
		// Token: 0x06002E25 RID: 11813 RVA: 0x00103530 File Offset: 0x00101730
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistLoader()
		{
			Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ChemistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr);
			ChemistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, 100668607);
			ChemistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, 100668608);
			ChemistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, 100668609);
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x0010359C File Offset: 0x0010179C
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128425, XrefRangeEnd = 128432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x001035E0 File Offset: 0x001017E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0010361C File Offset: 0x0010181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128432, XrefRangeEnd = 128513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00018919 File Offset: 0x00016B19
		public ChemistLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020008FE RID: 2302
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ChemistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C567 RID: 50535 RVA: 0x00300528 File Offset: 0x002FE728
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, "chemist");
				ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668610);
			}

			// Token: 0x0600C568 RID: 50536 RVA: 0x0030057C File Offset: 0x002FE77C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C569 RID: 50537 RVA: 0x000600E0 File Offset: 0x0005E2E0
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D94 RID: 15764
			// (get) Token: 0x0600C56A RID: 50538 RVA: 0x003005B8 File Offset: 0x002FE7B8
			// (set) Token: 0x0600C56B RID: 50539 RVA: 0x000600E9 File Offset: 0x0005E2E9
			public unsafe Chemist chemist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085C9 RID: 34249
			private static readonly IntPtr NativeFieldInfoPtr_chemist;

			// Token: 0x040085CA RID: 34250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FF RID: 2303
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ChemistLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x0600C56C RID: 50540 RVA: 0x003005E8 File Offset: 0x002FE7E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr);
				ChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				ChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				ChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668611);
				ChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668612);
			}

			// Token: 0x0600C56D RID: 50541 RVA: 0x00300664 File Offset: 0x002FE864
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C56E RID: 50542 RVA: 0x003006A0 File Offset: 0x002FE8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128395, XrefRangeEnd = 128412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C56F RID: 50543 RVA: 0x00060108 File Offset: 0x0005E308
			public __c__DisplayClass3_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D95 RID: 15765
			// (get) Token: 0x0600C570 RID: 50544 RVA: 0x003006D4 File Offset: 0x002FE8D4
			// (set) Token: 0x0600C571 RID: 50545 RVA: 0x00060111 File Offset: 0x0005E311
			public unsafe ChemistConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D96 RID: 15766
			// (get) Token: 0x0600C572 RID: 50546 RVA: 0x00300704 File Offset: 0x002FE904
			// (set) Token: 0x0600C573 RID: 50547 RVA: 0x00060130 File Offset: 0x0005E330
			public unsafe ChemistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085CB RID: 34251
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x040085CC RID: 34252
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085CD RID: 34253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085CE RID: 34254
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000900 RID: 2304
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ChemistLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Object
		{
			// Token: 0x0600C574 RID: 50548 RVA: 0x00300734 File Offset: 0x002FE934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr);
				ChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				ChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				ChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668613);
				ChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668614);
			}

			// Token: 0x0600C575 RID: 50549 RVA: 0x003007B0 File Offset: 0x002FE9B0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C576 RID: 50550 RVA: 0x003007EC File Offset: 0x002FE9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128412, XrefRangeEnd = 128425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C577 RID: 50551 RVA: 0x0006014F File Offset: 0x0005E34F
			public __c__DisplayClass3_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D97 RID: 15767
			// (get) Token: 0x0600C578 RID: 50552 RVA: 0x00300820 File Offset: 0x002FEA20
			// (set) Token: 0x0600C579 RID: 50553 RVA: 0x00060158 File Offset: 0x0005E358
			public unsafe ChemistData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D98 RID: 15768
			// (get) Token: 0x0600C57A RID: 50554 RVA: 0x00300850 File Offset: 0x002FEA50
			// (set) Token: 0x0600C57B RID: 50555 RVA: 0x00060177 File Offset: 0x0005E377
			public unsafe ChemistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085CF RID: 34255
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040085D0 RID: 34256
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085D1 RID: 34257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085D2 RID: 34258
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
