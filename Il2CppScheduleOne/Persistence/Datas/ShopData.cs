using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B5 RID: 693
	public class ShopData : SaveData
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x0010E1BC File Offset: 0x0010C3BC
		// Note: this type is marked as 'beforefieldinit'.
		static ShopData()
		{
			Il2CppClassPointerStore<ShopData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShopData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopData>.NativeClassPtr);
			ShopData.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ShopCode");
			ShopData.NativeFieldInfoPtr_ItemStockQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ItemStockQuantities");
			ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopData>.NativeClassPtr, 100668847);
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0010E228 File Offset: 0x0010C428
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopData(string shopCode, Il2CppReferenceArray<StringIntPair> itemStockQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemStockQuantities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0001A9BE File Offset: 0x00018BBE
		public ShopData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x0010E288 File Offset: 0x0010C488
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x0001A9C7 File Offset: 0x00018BC7
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x0010E2B0 File Offset: 0x0010C4B0
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x0001A9E6 File Offset: 0x00018BE6
		public unsafe Il2CppReferenceArray<StringIntPair> ItemStockQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeFieldInfoPtr_ItemStockQuantities;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0;
	}
}
