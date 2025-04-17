using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A9 RID: 681
	[Serializable]
	public class CocaineProductData : ProductData
	{
		// Token: 0x06003138 RID: 12600 RVA: 0x0010CB80 File Offset: 0x0010AD80
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineProductData()
		{
			Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CocaineProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr);
			CocaineProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr, "AppearanceSettings");
			CocaineProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr, 100668831);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x0010CBD8 File Offset: 0x0010ADD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131000, RefRangeEnd = 131003, XrefRangeStart = 130995, XrefRangeEnd = 131000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, CocaineAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x0001A467 File Offset: 0x00018667
		public CocaineProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x0010CC6C File Offset: 0x0010AE6C
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x0001A470 File Offset: 0x00018670
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0;
	}
}
