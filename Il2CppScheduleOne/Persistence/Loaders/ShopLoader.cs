using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000236 RID: 566
	public class ShopLoader : Loader
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x00102BF0 File Offset: 0x00100DF0
		// Note: this type is marked as 'beforefieldinit'.
		static ShopLoader()
		{
			Il2CppClassPointerStore<ShopLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ShopLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr);
			ShopLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr, 100668579);
			ShopLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr, 100668580);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00102C48 File Offset: 0x00100E48
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00102C84 File Offset: 0x00100E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127995, XrefRangeEnd = 128014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000188BF File Offset: 0x00016ABF
		public ShopLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020008FA RID: 2298
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ShopLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600C54C RID: 50508 RVA: 0x003000AC File Offset: 0x002FE2AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr);
				ShopLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr, "data");
				ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668581);
				ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr, 100668582);
			}

			// Token: 0x0600C54D RID: 50509 RVA: 0x00300114 File Offset: 0x002FE314
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C54E RID: 50510 RVA: 0x00300150 File Offset: 0x002FE350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127993, XrefRangeEnd = 127995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopInterface x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C54F RID: 50511 RVA: 0x00060002 File Offset: 0x0005E202
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8E RID: 15758
			// (get) Token: 0x0600C550 RID: 50512 RVA: 0x003001A0 File Offset: 0x002FE3A0
			// (set) Token: 0x0600C551 RID: 50513 RVA: 0x0006000B File Offset: 0x0005E20B
			public unsafe ShopData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085BC RID: 34236
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040085BD RID: 34237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085BE RID: 34238
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0;
		}
	}
}
