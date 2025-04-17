using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000241 RID: 577
	public class CleanerLoader : EmployeeLoader
	{
		// Token: 0x06002E2A RID: 11818 RVA: 0x0010366C File Offset: 0x0010186C
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerLoader()
		{
			Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CleanerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr);
			CleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100668615);
			CleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100668616);
			CleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100668617);
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x001036D8 File Offset: 0x001018D8
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128543, XrefRangeEnd = 128550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x0010371C File Offset: 0x0010191C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00103758 File Offset: 0x00101958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128550, XrefRangeEnd = 128631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00018922 File Offset: 0x00016B22
		public CleanerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000901 RID: 2305
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.CleanerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C57C RID: 50556 RVA: 0x00300880 File Offset: 0x002FEA80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "cleaner");
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668618);
			}

			// Token: 0x0600C57D RID: 50557 RVA: 0x003008D4 File Offset: 0x002FEAD4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C57E RID: 50558 RVA: 0x00060196 File Offset: 0x0005E396
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D99 RID: 15769
			// (get) Token: 0x0600C57F RID: 50559 RVA: 0x00300910 File Offset: 0x002FEB10
			// (set) Token: 0x0600C580 RID: 50560 RVA: 0x0006019F File Offset: 0x0005E39F
			public unsafe Cleaner cleaner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085D3 RID: 34259
			private static readonly IntPtr NativeFieldInfoPtr_cleaner;

			// Token: 0x040085D4 RID: 34260
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000902 RID: 2306
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.CleanerLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x0600C581 RID: 50561 RVA: 0x00300940 File Offset: 0x002FEB40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr);
				CleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				CleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				CleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668619);
				CleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100668620);
			}

			// Token: 0x0600C582 RID: 50562 RVA: 0x003009BC File Offset: 0x002FEBBC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C583 RID: 50563 RVA: 0x003009F8 File Offset: 0x002FEBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128513, XrefRangeEnd = 128530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C584 RID: 50564 RVA: 0x000601BE File Offset: 0x0005E3BE
			public __c__DisplayClass3_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D9A RID: 15770
			// (get) Token: 0x0600C585 RID: 50565 RVA: 0x00300A2C File Offset: 0x002FEC2C
			// (set) Token: 0x0600C586 RID: 50566 RVA: 0x000601C7 File Offset: 0x0005E3C7
			public unsafe CleanerConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D9B RID: 15771
			// (get) Token: 0x0600C587 RID: 50567 RVA: 0x00300A5C File Offset: 0x002FEC5C
			// (set) Token: 0x0600C588 RID: 50568 RVA: 0x000601E6 File Offset: 0x0005E3E6
			public unsafe CleanerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085D5 RID: 34261
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x040085D6 RID: 34262
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085D7 RID: 34263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085D8 RID: 34264
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000903 RID: 2307
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.CleanerLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Object
		{
			// Token: 0x0600C589 RID: 50569 RVA: 0x00300A8C File Offset: 0x002FEC8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr);
				CleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				CleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				CleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668621);
				CleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100668622);
			}

			// Token: 0x0600C58A RID: 50570 RVA: 0x00300B08 File Offset: 0x002FED08
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C58B RID: 50571 RVA: 0x00300B44 File Offset: 0x002FED44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128530, XrefRangeEnd = 128543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C58C RID: 50572 RVA: 0x00060205 File Offset: 0x0005E405
			public __c__DisplayClass3_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D9C RID: 15772
			// (get) Token: 0x0600C58D RID: 50573 RVA: 0x00300B78 File Offset: 0x002FED78
			// (set) Token: 0x0600C58E RID: 50574 RVA: 0x0006020E File Offset: 0x0005E40E
			public unsafe CleanerData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D9D RID: 15773
			// (get) Token: 0x0600C58F RID: 50575 RVA: 0x00300BA8 File Offset: 0x002FEDA8
			// (set) Token: 0x0600C590 RID: 50576 RVA: 0x0006022D File Offset: 0x0005E42D
			public unsafe CleanerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085D9 RID: 34265
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040085DA RID: 34266
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x040085DB RID: 34267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085DC RID: 34268
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
