using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000709 RID: 1801
	public class ClothingShopListing : ShopListing
	{
		// Token: 0x0600A1CC RID: 41420 RVA: 0x0028AF68 File Offset: 0x00289168
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopListing()
		{
			Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr);
			ClothingShopListing.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, "Color");
			ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, 100683095);
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x0028AFC0 File Offset: 0x002891C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284033, XrefRangeEnd = 284034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x0004F971 File Offset: 0x0004DB71
		public ClothingShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600A1CF RID: 41423 RVA: 0x0028AFFC File Offset: 0x002891FC
		// (set) Token: 0x0600A1D0 RID: 41424 RVA: 0x0004F97A File Offset: 0x0004DB7A
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04006C79 RID: 27769
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04006C7A RID: 27770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
