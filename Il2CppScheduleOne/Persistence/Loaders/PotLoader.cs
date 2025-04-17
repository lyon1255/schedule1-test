using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200024F RID: 591
	public class PotLoader : GridItemLoader
	{
		// Token: 0x06002E74 RID: 11892 RVA: 0x00104944 File Offset: 0x00102B44
		// Note: this type is marked as 'beforefieldinit'.
		static PotLoader()
		{
			Il2CppClassPointerStore<PotLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PotLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotLoader>.NativeClassPtr);
			PotLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668687);
			PotLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668688);
			PotLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, 100668689);
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x001049B0 File Offset: 0x00102BB0
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129888, XrefRangeEnd = 129895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x001049F4 File Offset: 0x00102BF4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00104A30 File Offset: 0x00102C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129895, XrefRangeEnd = 129958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000189A0 File Offset: 0x00016BA0
		public PotLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000910 RID: 2320
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.PotLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C5E5 RID: 50661 RVA: 0x003019BC File Offset: 0x002FFBBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr);
				PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, "pot");
				PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668690);
				PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668691);
			}

			// Token: 0x0600C5E6 RID: 50662 RVA: 0x00301A38 File Offset: 0x002FFC38
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5E7 RID: 50663 RVA: 0x00301A74 File Offset: 0x002FFC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129868, XrefRangeEnd = 129888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5E8 RID: 50664 RVA: 0x0006051B File Offset: 0x0005E71B
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DB2 RID: 15794
			// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x00301AA8 File Offset: 0x002FFCA8
			// (set) Token: 0x0600C5EA RID: 50666 RVA: 0x00060524 File Offset: 0x0005E724
			public unsafe Pot pot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_pot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DB3 RID: 15795
			// (get) Token: 0x0600C5EB RID: 50667 RVA: 0x00301AD8 File Offset: 0x002FFCD8
			// (set) Token: 0x0600C5EC RID: 50668 RVA: 0x00060543 File Offset: 0x0005E743
			public unsafe PotConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008607 RID: 34311
			private static readonly IntPtr NativeFieldInfoPtr_pot;

			// Token: 0x04008608 RID: 34312
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04008609 RID: 34313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400860A RID: 34314
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
