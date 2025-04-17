using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000245 RID: 581
	public class BrickPressLoader : GridItemLoader
	{
		// Token: 0x06002E3F RID: 11839 RVA: 0x00103BC4 File Offset: 0x00101DC4
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressLoader()
		{
			Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BrickPressLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr);
			BrickPressLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr, 100668640);
			BrickPressLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr, 100668641);
			BrickPressLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr, 100668642);
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x00103C30 File Offset: 0x00101E30
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129026, XrefRangeEnd = 129033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00103C74 File Offset: 0x00101E74
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129033, XrefRangeEnd = 129034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00103CB0 File Offset: 0x00101EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129043, XrefRangeEnd = 129109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00018946 File Offset: 0x00016B46
		public BrickPressLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x02000908 RID: 2312
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.BrickPressLoader+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600C5AC RID: 50604 RVA: 0x00301054 File Offset: 0x002FF254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BrickPressLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr);
				BrickPressLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_brickPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr, "brickPress");
				BrickPressLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				BrickPressLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668643);
				BrickPressLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr, 100668644);
			}

			// Token: 0x0600C5AD RID: 50605 RVA: 0x003010D0 File Offset: 0x002FF2D0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5AE RID: 50606 RVA: 0x0030110C File Offset: 0x002FF30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129010, XrefRangeEnd = 129026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5AF RID: 50607 RVA: 0x0006032A File Offset: 0x0005E52A
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DA4 RID: 15780
			// (get) Token: 0x0600C5B0 RID: 50608 RVA: 0x00301140 File Offset: 0x002FF340
			// (set) Token: 0x0600C5B1 RID: 50609 RVA: 0x00060333 File Offset: 0x0005E533
			public unsafe BrickPress brickPress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_brickPress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_brickPress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DA5 RID: 15781
			// (get) Token: 0x0600C5B2 RID: 50610 RVA: 0x00301170 File Offset: 0x002FF370
			// (set) Token: 0x0600C5B3 RID: 50611 RVA: 0x00060352 File Offset: 0x0005E552
			public unsafe BrickPressConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPressConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085EA RID: 34282
			private static readonly IntPtr NativeFieldInfoPtr_brickPress;

			// Token: 0x040085EB RID: 34283
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x040085EC RID: 34284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085ED RID: 34285
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
