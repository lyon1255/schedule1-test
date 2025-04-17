using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AC RID: 1708
	public class ListingEntry : MonoBehaviour
	{
		// Token: 0x06009956 RID: 39254 RVA: 0x00271084 File Offset: 0x0026F284
		// Note: this type is marked as 'beforefieldinit'.
		static ListingEntry()
		{
			Il2CppClassPointerStore<ListingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "ListingEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr);
			ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<MatchingListing>k__BackingField");
			ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<SelectedQuantity>k__BackingField");
			ListingEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "Icon");
			ListingEntry.NativeFieldInfoPtr_ItemNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemNameLabel");
			ListingEntry.NativeFieldInfoPtr_ItemPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemPriceLabel");
			ListingEntry.NativeFieldInfoPtr_QuantityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "QuantityInput");
			ListingEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "IncrementButton");
			ListingEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "DecrementButton");
			ListingEntry.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "LockedContainer");
			ListingEntry.NativeFieldInfoPtr_onQuantityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "onQuantityChanged");
			ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682211);
			ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682212);
			ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682213);
			ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682214);
			ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682215);
			ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682216);
			ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682217);
			ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682218);
			ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682219);
			ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682220);
			ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682221);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682222);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682223);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682224);
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x06009957 RID: 39255 RVA: 0x00271294 File Offset: 0x0026F494
		// (set) Token: 0x06009958 RID: 39256 RVA: 0x002712D4 File Offset: 0x0026F4D4
		public unsafe ShopListing MatchingListing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x06009959 RID: 39257 RVA: 0x00271318 File Offset: 0x0026F518
		// (set) Token: 0x0600995A RID: 39258 RVA: 0x00271354 File Offset: 0x0026F554
		public unsafe int SelectedQuantity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x00271394 File Offset: 0x0026F594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273474, RefRangeEnd = 273475, XrefRangeStart = 273438, XrefRangeEnd = 273474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopListing match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x002713D8 File Offset: 0x0026F5D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273481, RefRangeEnd = 273482, XrefRangeStart = 273475, XrefRangeEnd = 273481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x0027140C File Offset: 0x0026F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273482, XrefRangeEnd = 273487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quant, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quant;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600995E RID: 39262 RVA: 0x00271458 File Offset: 0x0026F658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273492, RefRangeEnd = 273494, XrefRangeStart = 273487, XrefRangeEnd = 273492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00271498 File Offset: 0x0026F698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273494, XrefRangeEnd = 273499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuantityInputSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x002714DC File Offset: 0x0026F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273499, XrefRangeEnd = 273508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009961 RID: 39265 RVA: 0x00271510 File Offset: 0x0026F710
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009962 RID: 39266 RVA: 0x0027154C File Offset: 0x0026F74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273508, XrefRangeEnd = 273517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_0(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x00271590 File Offset: 0x0026F790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273517, XrefRangeEnd = 273518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x002715C4 File Offset: 0x0026F7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273518, XrefRangeEnd = 273519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009965 RID: 39269 RVA: 0x0004AC73 File Offset: 0x00048E73
		public ListingEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x06009966 RID: 39270 RVA: 0x002715F8 File Offset: 0x0026F7F8
		// (set) Token: 0x06009967 RID: 39271 RVA: 0x0004AC7C File Offset: 0x00048E7C
		public unsafe ShopListing _MatchingListing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x06009968 RID: 39272 RVA: 0x00271628 File Offset: 0x0026F828
		// (set) Token: 0x06009969 RID: 39273 RVA: 0x0004AC9B File Offset: 0x00048E9B
		public unsafe int _SelectedQuantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600996A RID: 39274 RVA: 0x00271650 File Offset: 0x0026F850
		// (set) Token: 0x0600996B RID: 39275 RVA: 0x0004ACB6 File Offset: 0x00048EB6
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600996C RID: 39276 RVA: 0x00271680 File Offset: 0x0026F880
		// (set) Token: 0x0600996D RID: 39277 RVA: 0x0004ACD5 File Offset: 0x00048ED5
		public unsafe Text ItemNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600996E RID: 39278 RVA: 0x002716B0 File Offset: 0x0026F8B0
		// (set) Token: 0x0600996F RID: 39279 RVA: 0x0004ACF4 File Offset: 0x00048EF4
		public unsafe Text ItemPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x002716E0 File Offset: 0x0026F8E0
		// (set) Token: 0x06009971 RID: 39281 RVA: 0x0004AD13 File Offset: 0x00048F13
		public unsafe InputField QuantityInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x00271710 File Offset: 0x0026F910
		// (set) Token: 0x06009973 RID: 39283 RVA: 0x0004AD32 File Offset: 0x00048F32
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x06009974 RID: 39284 RVA: 0x00271740 File Offset: 0x0026F940
		// (set) Token: 0x06009975 RID: 39285 RVA: 0x0004AD51 File Offset: 0x00048F51
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x06009976 RID: 39286 RVA: 0x00271770 File Offset: 0x0026F970
		// (set) Token: 0x06009977 RID: 39287 RVA: 0x0004AD70 File Offset: 0x00048F70
		public unsafe RectTransform LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06009978 RID: 39288 RVA: 0x002717A0 File Offset: 0x0026F9A0
		// (set) Token: 0x06009979 RID: 39289 RVA: 0x0004AD8F File Offset: 0x00048F8F
		public unsafe UnityEvent onQuantityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400673B RID: 26427
		private static readonly IntPtr NativeFieldInfoPtr__MatchingListing_k__BackingField;

		// Token: 0x0400673C RID: 26428
		private static readonly IntPtr NativeFieldInfoPtr__SelectedQuantity_k__BackingField;

		// Token: 0x0400673D RID: 26429
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400673E RID: 26430
		private static readonly IntPtr NativeFieldInfoPtr_ItemNameLabel;

		// Token: 0x0400673F RID: 26431
		private static readonly IntPtr NativeFieldInfoPtr_ItemPriceLabel;

		// Token: 0x04006740 RID: 26432
		private static readonly IntPtr NativeFieldInfoPtr_QuantityInput;

		// Token: 0x04006741 RID: 26433
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04006742 RID: 26434
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04006743 RID: 26435
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04006744 RID: 26436
		private static readonly IntPtr NativeFieldInfoPtr_onQuantityChanged;

		// Token: 0x04006745 RID: 26437
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0;

		// Token: 0x04006746 RID: 26438
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0;

		// Token: 0x04006747 RID: 26439
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0;

		// Token: 0x04006748 RID: 26440
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0;

		// Token: 0x04006749 RID: 26441
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0;

		// Token: 0x0400674A RID: 26442
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLocked_Public_Void_0;

		// Token: 0x0400674B RID: 26443
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x0400674C RID: 26444
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0;

		// Token: 0x0400674D RID: 26445
		private static readonly IntPtr NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0;

		// Token: 0x0400674E RID: 26446
		private static readonly IntPtr NativeMethodInfoPtr_ValidateInput_Private_Void_0;

		// Token: 0x0400674F RID: 26447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006750 RID: 26448
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0;

		// Token: 0x04006751 RID: 26449
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0;

		// Token: 0x04006752 RID: 26450
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0;
	}
}
