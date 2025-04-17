using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200023F RID: 575
	public class BotanistLoader : EmployeeLoader
	{
		// Token: 0x06002E20 RID: 11808 RVA: 0x001033F4 File Offset: 0x001015F4
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistLoader()
		{
			Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BotanistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr);
			BotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100668599);
			BotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100668600);
			BotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100668601);
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x00103460 File Offset: 0x00101660
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128306, XrefRangeEnd = 128313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x001034A4 File Offset: 0x001016A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128313, XrefRangeEnd = 128314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x001034E0 File Offset: 0x001016E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128314, XrefRangeEnd = 128395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00018910 File Offset: 0x00016B10
		public BotanistLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020008FB RID: 2299
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.BotanistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C552 RID: 50514 RVA: 0x003001D0 File Offset: 0x002FE3D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "botanist");
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668602);
			}

			// Token: 0x0600C553 RID: 50515 RVA: 0x00300224 File Offset: 0x002FE424
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C554 RID: 50516 RVA: 0x0006002A File Offset: 0x0005E22A
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8F RID: 15759
			// (get) Token: 0x0600C555 RID: 50517 RVA: 0x00300260 File Offset: 0x002FE460
			// (set) Token: 0x0600C556 RID: 50518 RVA: 0x00060033 File Offset: 0x0005E233
			public unsafe Botanist botanist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085BF RID: 34239
			private static readonly IntPtr NativeFieldInfoPtr_botanist;

			// Token: 0x040085C0 RID: 34240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FC RID: 2300
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.BotanistLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x0600C557 RID: 50519 RVA: 0x00300290 File Offset: 0x002FE490
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr);
				BotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				BotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				BotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668603);
				BotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668604);
			}

			// Token: 0x0600C558 RID: 50520 RVA: 0x0030030C File Offset: 0x002FE50C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C559 RID: 50521 RVA: 0x00300348 File Offset: 0x002FE548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128275, XrefRangeEnd = 128293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C55A RID: 50522 RVA: 0x00060052 File Offset: 0x0005E252
			public __c__DisplayClass3_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D90 RID: 15760
			// (get) Token: 0x0600C55B RID: 50523 RVA: 0x0030037C File Offset: 0x002FE57C
			// (set) Token: 0x0600C55C RID: 50524 RVA: 0x0006005B File Offset: 0x0005E25B
			public unsafe BotanistConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D91 RID: 15761
			// (get) Token: 0x0600C55D RID: 50525 RVA: 0x003003AC File Offset: 0x002FE5AC
			// (set) Token: 0x0600C55E RID: 50526 RVA: 0x0006007A File Offset: 0x0005E27A
			public unsafe BotanistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085C1 RID: 34241
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x040085C2 RID: 34242
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085C3 RID: 34243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085C4 RID: 34244
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020008FD RID: 2301
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.BotanistLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Object
		{
			// Token: 0x0600C55F RID: 50527 RVA: 0x003003DC File Offset: 0x002FE5DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr);
				BotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				BotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				BotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668605);
				BotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668606);
			}

			// Token: 0x0600C560 RID: 50528 RVA: 0x00300458 File Offset: 0x002FE658
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C561 RID: 50529 RVA: 0x00300494 File Offset: 0x002FE694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128293, XrefRangeEnd = 128306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C562 RID: 50530 RVA: 0x00060099 File Offset: 0x0005E299
			public __c__DisplayClass3_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D92 RID: 15762
			// (get) Token: 0x0600C563 RID: 50531 RVA: 0x003004C8 File Offset: 0x002FE6C8
			// (set) Token: 0x0600C564 RID: 50532 RVA: 0x000600A2 File Offset: 0x0005E2A2
			public unsafe BotanistData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D93 RID: 15763
			// (get) Token: 0x0600C565 RID: 50533 RVA: 0x003004F8 File Offset: 0x002FE6F8
			// (set) Token: 0x0600C566 RID: 50534 RVA: 0x000600C1 File Offset: 0x0005E2C1
			public unsafe BotanistLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085C5 RID: 34245
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040085C6 RID: 34246
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085C7 RID: 34247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085C8 RID: 34248
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
