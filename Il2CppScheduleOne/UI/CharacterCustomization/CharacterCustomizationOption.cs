using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F8 RID: 1784
	public class CharacterCustomizationOption : MonoBehaviour
	{
		// Token: 0x06009FF0 RID: 40944 RVA: 0x00284D10 File Offset: 0x00282F10
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationOption()
		{
			Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr);
			CharacterCustomizationOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Name");
			CharacterCustomizationOption.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Label");
			CharacterCustomizationOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Price");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequireLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequiredLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "NameLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "PriceLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LevelLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LockDisplay");
			CharacterCustomizationOption.NativeFieldInfoPtr_MainButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "MainButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "BuyButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "SelectionIndicator");
			CharacterCustomizationOption.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onSelect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onDeselect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onPurchase");
			CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "<purchased>k__BackingField");
			CharacterCustomizationOption.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "selected");
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682867);
			CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682868);
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682869);
			CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682870);
			CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682871);
			CharacterCustomizationOption.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682872);
			CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682873);
			CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682874);
			CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682875);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682876);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682877);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682878);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682879);
			CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682880);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682881);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682882);
			CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100682883);
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x06009FF1 RID: 40945 RVA: 0x00284FE8 File Offset: 0x002831E8
		// (set) Token: 0x06009FF2 RID: 40946 RVA: 0x00285024 File Offset: 0x00283224
		public unsafe bool purchased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x06009FF3 RID: 40947 RVA: 0x00285064 File Offset: 0x00283264
		public unsafe bool purchaseable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 281818, RefRangeEnd = 281822, XrefRangeStart = 281817, XrefRangeEnd = 281818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x002850A0 File Offset: 0x002832A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281822, XrefRangeEnd = 281842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x002850D4 File Offset: 0x002832D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x00285108 File Offset: 0x00283308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281842, XrefRangeEnd = 281848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x0028513C File Offset: 0x0028333C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281848, XrefRangeEnd = 281849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF8 RID: 40952 RVA: 0x00285170 File Offset: 0x00283370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281849, XrefRangeEnd = 281850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x002851A4 File Offset: 0x002833A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281850, XrefRangeEnd = 281866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Purchased()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x002851D8 File Offset: 0x002833D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281879, RefRangeEnd = 281881, XrefRangeStart = 281866, XrefRangeEnd = 281879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x0028520C File Offset: 0x0028340C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 281890, RefRangeEnd = 281901, XrefRangeStart = 281881, XrefRangeEnd = 281890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(bool _selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _selected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x0028524C File Offset: 0x0028344C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281908, RefRangeEnd = 281910, XrefRangeStart = 281901, XrefRangeEnd = 281908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPurchased(bool _purchased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _purchased;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x0028528C File Offset: 0x0028348C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 281922, RefRangeEnd = 281930, XrefRangeStart = 281910, XrefRangeEnd = 281922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x002852C0 File Offset: 0x002834C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281930, XrefRangeEnd = 281932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParentCategoryClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x002852F4 File Offset: 0x002834F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281932, XrefRangeEnd = 281937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x00285338 File Offset: 0x00283538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281937, XrefRangeEnd = 281946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x0028537C File Offset: 0x0028357C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281946, XrefRangeEnd = 281956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x0004E9CA File Offset: 0x0004CBCA
		public CharacterCustomizationOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x002853B8 File Offset: 0x002835B8
		// (set) Token: 0x0600A004 RID: 40964 RVA: 0x0004E9D3 File Offset: 0x0004CBD3
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600A005 RID: 40965 RVA: 0x002853E0 File Offset: 0x002835E0
		// (set) Token: 0x0600A006 RID: 40966 RVA: 0x0004E9F2 File Offset: 0x0004CBF2
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600A007 RID: 40967 RVA: 0x00285408 File Offset: 0x00283608
		// (set) Token: 0x0600A008 RID: 40968 RVA: 0x0004EA11 File Offset: 0x0004CC11
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600A009 RID: 40969 RVA: 0x00285430 File Offset: 0x00283630
		// (set) Token: 0x0600A00A RID: 40970 RVA: 0x0004EA2C File Offset: 0x0004CC2C
		public unsafe bool RequireLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel)) = value;
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x00285458 File Offset: 0x00283658
		// (set) Token: 0x0600A00C RID: 40972 RVA: 0x0004EA47 File Offset: 0x0004CC47
		public unsafe FullRank RequiredLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel)) = value;
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600A00D RID: 40973 RVA: 0x00285480 File Offset: 0x00283680
		// (set) Token: 0x0600A00E RID: 40974 RVA: 0x0004EA62 File Offset: 0x0004CC62
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600A00F RID: 40975 RVA: 0x002854B0 File Offset: 0x002836B0
		// (set) Token: 0x0600A010 RID: 40976 RVA: 0x0004EA81 File Offset: 0x0004CC81
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600A011 RID: 40977 RVA: 0x002854E0 File Offset: 0x002836E0
		// (set) Token: 0x0600A012 RID: 40978 RVA: 0x0004EAA0 File Offset: 0x0004CCA0
		public unsafe TextMeshProUGUI LevelLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600A013 RID: 40979 RVA: 0x00285510 File Offset: 0x00283710
		// (set) Token: 0x0600A014 RID: 40980 RVA: 0x0004EABF File Offset: 0x0004CCBF
		public unsafe RectTransform LockDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600A015 RID: 40981 RVA: 0x00285540 File Offset: 0x00283740
		// (set) Token: 0x0600A016 RID: 40982 RVA: 0x0004EADE File Offset: 0x0004CCDE
		public unsafe Button MainButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600A017 RID: 40983 RVA: 0x00285570 File Offset: 0x00283770
		// (set) Token: 0x0600A018 RID: 40984 RVA: 0x0004EAFD File Offset: 0x0004CCFD
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600A019 RID: 40985 RVA: 0x002855A0 File Offset: 0x002837A0
		// (set) Token: 0x0600A01A RID: 40986 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x002855D0 File Offset: 0x002837D0
		// (set) Token: 0x0600A01C RID: 40988 RVA: 0x0004EB3B File Offset: 0x0004CD3B
		public unsafe UnityEvent onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x00285600 File Offset: 0x00283800
		// (set) Token: 0x0600A01E RID: 40990 RVA: 0x0004EB5A File Offset: 0x0004CD5A
		public unsafe UnityEvent onDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x00285630 File Offset: 0x00283830
		// (set) Token: 0x0600A020 RID: 40992 RVA: 0x0004EB79 File Offset: 0x0004CD79
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600A021 RID: 40993 RVA: 0x00285660 File Offset: 0x00283860
		// (set) Token: 0x0600A022 RID: 40994 RVA: 0x0004EB98 File Offset: 0x0004CD98
		public unsafe bool _purchased_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField)) = value;
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600A023 RID: 40995 RVA: 0x00285688 File Offset: 0x00283888
		// (set) Token: 0x0600A024 RID: 40996 RVA: 0x0004EBB3 File Offset: 0x0004CDB3
		public unsafe bool selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected)) = value;
			}
		}

		// Token: 0x04006B40 RID: 27456
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04006B41 RID: 27457
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006B42 RID: 27458
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04006B43 RID: 27459
		private static readonly IntPtr NativeFieldInfoPtr_RequireLevel;

		// Token: 0x04006B44 RID: 27460
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLevel;

		// Token: 0x04006B45 RID: 27461
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006B46 RID: 27462
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006B47 RID: 27463
		private static readonly IntPtr NativeFieldInfoPtr_LevelLabel;

		// Token: 0x04006B48 RID: 27464
		private static readonly IntPtr NativeFieldInfoPtr_LockDisplay;

		// Token: 0x04006B49 RID: 27465
		private static readonly IntPtr NativeFieldInfoPtr_MainButton;

		// Token: 0x04006B4A RID: 27466
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006B4B RID: 27467
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006B4C RID: 27468
		private static readonly IntPtr NativeFieldInfoPtr_onSelect;

		// Token: 0x04006B4D RID: 27469
		private static readonly IntPtr NativeFieldInfoPtr_onDeselect;

		// Token: 0x04006B4E RID: 27470
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x04006B4F RID: 27471
		private static readonly IntPtr NativeFieldInfoPtr__purchased_k__BackingField;

		// Token: 0x04006B50 RID: 27472
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04006B51 RID: 27473
		private static readonly IntPtr NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0;

		// Token: 0x04006B52 RID: 27474
		private static readonly IntPtr NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0;

		// Token: 0x04006B53 RID: 27475
		private static readonly IntPtr NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0;

		// Token: 0x04006B54 RID: 27476
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006B55 RID: 27477
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006B56 RID: 27478
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006B57 RID: 27479
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006B58 RID: 27480
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Private_Void_0;

		// Token: 0x04006B59 RID: 27481
		private static readonly IntPtr NativeMethodInfoPtr_Purchased_Private_Void_0;

		// Token: 0x04006B5A RID: 27482
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0;

		// Token: 0x04006B5B RID: 27483
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;

		// Token: 0x04006B5C RID: 27484
		private static readonly IntPtr NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0;

		// Token: 0x04006B5D RID: 27485
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006B5E RID: 27486
		private static readonly IntPtr NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0;

		// Token: 0x04006B5F RID: 27487
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B60 RID: 27488
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B61 RID: 27489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
