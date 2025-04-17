using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x02000723 RID: 1827
	public class FI_OptionList : FI_Base
	{
		// Token: 0x0600A482 RID: 42114 RVA: 0x0029365C File Offset: 0x0029185C
		// Note: this type is marked as 'beforefieldinit'.
		static FI_OptionList()
		{
			Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_OptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr);
			FI_OptionList.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buttonContainer");
			FI_OptionList.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buyButton");
			FI_OptionList.NativeFieldInfoPtr_buyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buyButtonText");
			FI_OptionList.NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "bar");
			FI_OptionList.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buttonPrefab");
			FI_OptionList.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "onSelectionChanged");
			FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "onSelectionPurchased");
			FI_OptionList.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "options");
			FI_OptionList.NativeFieldInfoPtr_specificFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "specificFeature");
			FI_OptionList.NativeFieldInfoPtr_selectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "selectionIndex");
			FI_OptionList.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683396);
			FI_OptionList.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683397);
			FI_OptionList.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683398);
			FI_OptionList.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683399);
			FI_OptionList.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683400);
			FI_OptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683401);
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x002937CC File Offset: 0x002919CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287535, XrefRangeEnd = 287592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(OptionListFeature _feature, List<FI_OptionList.Option> _options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_OptionList.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x0029382C File Offset: 0x00291A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287592, XrefRangeEnd = 287600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_OptionList.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x00293868 File Offset: 0x00291A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287600, XrefRangeEnd = 287626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x0029389C File Offset: 0x00291A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287633, RefRangeEnd = 287635, XrefRangeStart = 287626, XrefRangeEnd = 287633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x002938DC File Offset: 0x00291ADC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287694, RefRangeEnd = 287697, XrefRangeStart = 287635, XrefRangeEnd = 287694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x00293910 File Offset: 0x00291B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287697, XrefRangeEnd = 287705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_OptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x0005119B File Offset: 0x0004F39B
		public FI_OptionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x0029394C File Offset: 0x00291B4C
		// (set) Token: 0x0600A48B RID: 42123 RVA: 0x000511A4 File Offset: 0x0004F3A4
		public unsafe RectTransform buttonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A48C RID: 42124 RVA: 0x0029397C File Offset: 0x00291B7C
		// (set) Token: 0x0600A48D RID: 42125 RVA: 0x000511C3 File Offset: 0x0004F3C3
		public unsafe Button buyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A48E RID: 42126 RVA: 0x002939AC File Offset: 0x00291BAC
		// (set) Token: 0x0600A48F RID: 42127 RVA: 0x000511E2 File Offset: 0x0004F3E2
		public unsafe TextMeshProUGUI buyButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A490 RID: 42128 RVA: 0x002939DC File Offset: 0x00291BDC
		// (set) Token: 0x0600A491 RID: 42129 RVA: 0x00051201 File Offset: 0x0004F401
		public unsafe RectTransform bar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_bar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A492 RID: 42130 RVA: 0x00293A0C File Offset: 0x00291C0C
		// (set) Token: 0x0600A493 RID: 42131 RVA: 0x00051220 File Offset: 0x0004F420
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A494 RID: 42132 RVA: 0x00293A3C File Offset: 0x00291C3C
		// (set) Token: 0x0600A495 RID: 42133 RVA: 0x0005123F File Offset: 0x0004F43F
		public unsafe UnityEvent<int> onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A496 RID: 42134 RVA: 0x00293A6C File Offset: 0x00291C6C
		// (set) Token: 0x0600A497 RID: 42135 RVA: 0x0005125E File Offset: 0x0004F45E
		public unsafe UnityEvent<int> onSelectionPurchased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A498 RID: 42136 RVA: 0x00293A9C File Offset: 0x00291C9C
		// (set) Token: 0x0600A499 RID: 42137 RVA: 0x0005127D File Offset: 0x0004F47D
		public unsafe List<FI_OptionList.Option> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A49A RID: 42138 RVA: 0x00293ACC File Offset: 0x00291CCC
		// (set) Token: 0x0600A49B RID: 42139 RVA: 0x0005129C File Offset: 0x0004F49C
		public unsafe OptionListFeature specificFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_specificFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionListFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_specificFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A49C RID: 42140 RVA: 0x00293AFC File Offset: 0x00291CFC
		// (set) Token: 0x0600A49D RID: 42141 RVA: 0x000512BB File Offset: 0x0004F4BB
		public unsafe int selectionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_selectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_selectionIndex)) = value;
			}
		}

		// Token: 0x04006E47 RID: 28231
		private static readonly IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x04006E48 RID: 28232
		private static readonly IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04006E49 RID: 28233
		private static readonly IntPtr NativeFieldInfoPtr_buyButtonText;

		// Token: 0x04006E4A RID: 28234
		private static readonly IntPtr NativeFieldInfoPtr_bar;

		// Token: 0x04006E4B RID: 28235
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04006E4C RID: 28236
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04006E4D RID: 28237
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionPurchased;

		// Token: 0x04006E4E RID: 28238
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006E4F RID: 28239
		private static readonly IntPtr NativeFieldInfoPtr_specificFeature;

		// Token: 0x04006E50 RID: 28240
		private static readonly IntPtr NativeFieldInfoPtr_selectionIndex;

		// Token: 0x04006E51 RID: 28241
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0;

		// Token: 0x04006E52 RID: 28242
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006E53 RID: 28243
		private static readonly IntPtr NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0;

		// Token: 0x04006E54 RID: 28244
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x04006E55 RID: 28245
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006E56 RID: 28246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC7 RID: 3015
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600DDCE RID: 56782 RVA: 0x00345B34 File Offset: 0x00343D34
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr);
				FI_OptionList.Option.NativeFieldInfoPtr_optionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionLabel");
				FI_OptionList.Option.NativeFieldInfoPtr_optionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionColor");
				FI_OptionList.Option.NativeFieldInfoPtr_optionPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionPrice");
				FI_OptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, 100683402);
			}

			// Token: 0x0600DDCF RID: 56783 RVA: 0x00345BB0 File Offset: 0x00343DB0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287531, RefRangeEnd = 287533, XrefRangeStart = 287529, XrefRangeEnd = 287531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option(string _optionLabel, Color _optionColor, float _optionPrice) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_optionLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _optionColor;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _optionPrice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD0 RID: 56784 RVA: 0x0006C1B7 File Offset: 0x0006A3B7
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B7 RID: 17591
			// (get) Token: 0x0600DDD1 RID: 56785 RVA: 0x00345C18 File Offset: 0x00343E18
			// (set) Token: 0x0600DDD2 RID: 56786 RVA: 0x0006C1C0 File Offset: 0x0006A3C0
			public unsafe string optionLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044B8 RID: 17592
			// (get) Token: 0x0600DDD3 RID: 56787 RVA: 0x00345C40 File Offset: 0x00343E40
			// (set) Token: 0x0600DDD4 RID: 56788 RVA: 0x0006C1DF File Offset: 0x0006A3DF
			public unsafe Color optionColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionColor)) = value;
				}
			}

			// Token: 0x170044B9 RID: 17593
			// (get) Token: 0x0600DDD5 RID: 56789 RVA: 0x00345C68 File Offset: 0x00343E68
			// (set) Token: 0x0600DDD6 RID: 56790 RVA: 0x0006C1FA File Offset: 0x0006A3FA
			public unsafe float optionPrice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionPrice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionPrice)) = value;
				}
			}

			// Token: 0x0400948B RID: 38027
			private static readonly IntPtr NativeFieldInfoPtr_optionLabel;

			// Token: 0x0400948C RID: 38028
			private static readonly IntPtr NativeFieldInfoPtr_optionColor;

			// Token: 0x0400948D RID: 38029
			private static readonly IntPtr NativeFieldInfoPtr_optionPrice;

			// Token: 0x0400948E RID: 38030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0;
		}

		// Token: 0x02000BC8 RID: 3016
		[ObfuscatedName("ScheduleOne.UI.Construction.Features.FI_OptionList+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDD7 RID: 56791 RVA: 0x00345C90 File Offset: 0x00343E90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr);
				FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, "index");
				FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, 100683403);
				FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, 100683404);
			}

			// Token: 0x0600DDD8 RID: 56792 RVA: 0x00345D0C File Offset: 0x00343F0C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDD9 RID: 56793 RVA: 0x00345D48 File Offset: 0x00343F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287533, XrefRangeEnd = 287535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDDA RID: 56794 RVA: 0x0006C215 File Offset: 0x0006A415
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BA RID: 17594
			// (get) Token: 0x0600DDDB RID: 56795 RVA: 0x00345D7C File Offset: 0x00343F7C
			// (set) Token: 0x0600DDDC RID: 56796 RVA: 0x0006C21E File Offset: 0x0006A41E
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170044BB RID: 17595
			// (get) Token: 0x0600DDDD RID: 56797 RVA: 0x00345DA4 File Offset: 0x00343FA4
			// (set) Token: 0x0600DDDE RID: 56798 RVA: 0x0006C239 File Offset: 0x0006A439
			public unsafe FI_OptionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_OptionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400948F RID: 38031
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009490 RID: 38032
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009491 RID: 38033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009492 RID: 38034
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
		}
	}
}
