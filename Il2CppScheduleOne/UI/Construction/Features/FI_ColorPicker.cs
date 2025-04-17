using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x02000721 RID: 1825
	public class FI_ColorPicker : FI_Base
	{
		// Token: 0x0600A45D RID: 42077 RVA: 0x00292FE8 File Offset: 0x002911E8
		// Note: this type is marked as 'beforefieldinit'.
		static FI_ColorPicker()
		{
			Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_ColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr);
			FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorButtonContainer");
			FI_ColorPicker.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "buyButton");
			FI_ColorPicker.NativeFieldInfoPtr_buyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "buyButtonText");
			FI_ColorPicker.NativeFieldInfoPtr_colorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorLabel");
			FI_ColorPicker.NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "bar");
			FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorButtonPrefab");
			FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "onSelectionChanged");
			FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "onSelectionPurchased");
			FI_ColorPicker.NativeFieldInfoPtr_specificFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "specificFeature");
			FI_ColorPicker.NativeFieldInfoPtr_selectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "selectionIndex");
			FI_ColorPicker.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683385);
			FI_ColorPicker.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683386);
			FI_ColorPicker.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683387);
			FI_ColorPicker.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683388);
			FI_ColorPicker.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683389);
			FI_ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683390);
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x00293158 File Offset: 0x00291358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287360, XrefRangeEnd = 287411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_ColorPicker.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x002931A8 File Offset: 0x002913A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287411, XrefRangeEnd = 287419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_ColorPicker.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x002931E4 File Offset: 0x002913E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287419, XrefRangeEnd = 287447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x00293218 File Offset: 0x00291418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287457, RefRangeEnd = 287459, XrefRangeStart = 287447, XrefRangeEnd = 287457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x00293258 File Offset: 0x00291458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287520, RefRangeEnd = 287523, XrefRangeStart = 287459, XrefRangeEnd = 287520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x0029328C File Offset: 0x0029148C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_ColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x00051019 File Offset: 0x0004F219
		public FI_ColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600A465 RID: 42085 RVA: 0x002932C8 File Offset: 0x002914C8
		// (set) Token: 0x0600A466 RID: 42086 RVA: 0x00051022 File Offset: 0x0004F222
		public unsafe RectTransform colorButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600A467 RID: 42087 RVA: 0x002932F8 File Offset: 0x002914F8
		// (set) Token: 0x0600A468 RID: 42088 RVA: 0x00051041 File Offset: 0x0004F241
		public unsafe Button buyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A469 RID: 42089 RVA: 0x00293328 File Offset: 0x00291528
		// (set) Token: 0x0600A46A RID: 42090 RVA: 0x00051060 File Offset: 0x0004F260
		public unsafe TextMeshProUGUI buyButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A46B RID: 42091 RVA: 0x00293358 File Offset: 0x00291558
		// (set) Token: 0x0600A46C RID: 42092 RVA: 0x0005107F File Offset: 0x0004F27F
		public unsafe TextMeshProUGUI colorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x00293388 File Offset: 0x00291588
		// (set) Token: 0x0600A46E RID: 42094 RVA: 0x0005109E File Offset: 0x0004F29E
		public unsafe RectTransform bar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_bar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A46F RID: 42095 RVA: 0x002933B8 File Offset: 0x002915B8
		// (set) Token: 0x0600A470 RID: 42096 RVA: 0x000510BD File Offset: 0x0004F2BD
		public unsafe GameObject colorButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x002933E8 File Offset: 0x002915E8
		// (set) Token: 0x0600A472 RID: 42098 RVA: 0x000510DC File Offset: 0x0004F2DC
		public unsafe UnityEvent<ColorFeature.NamedColor> onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A473 RID: 42099 RVA: 0x00293418 File Offset: 0x00291618
		// (set) Token: 0x0600A474 RID: 42100 RVA: 0x000510FB File Offset: 0x0004F2FB
		public unsafe UnityEvent<ColorFeature.NamedColor> onSelectionPurchased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A475 RID: 42101 RVA: 0x00293448 File Offset: 0x00291648
		// (set) Token: 0x0600A476 RID: 42102 RVA: 0x0005111A File Offset: 0x0004F31A
		public unsafe ColorFeature specificFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_specificFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_specificFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A477 RID: 42103 RVA: 0x00293478 File Offset: 0x00291678
		// (set) Token: 0x0600A478 RID: 42104 RVA: 0x00051139 File Offset: 0x0004F339
		public unsafe int selectionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_selectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_selectionIndex)) = value;
			}
		}

		// Token: 0x04006E32 RID: 28210
		private static readonly IntPtr NativeFieldInfoPtr_colorButtonContainer;

		// Token: 0x04006E33 RID: 28211
		private static readonly IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04006E34 RID: 28212
		private static readonly IntPtr NativeFieldInfoPtr_buyButtonText;

		// Token: 0x04006E35 RID: 28213
		private static readonly IntPtr NativeFieldInfoPtr_colorLabel;

		// Token: 0x04006E36 RID: 28214
		private static readonly IntPtr NativeFieldInfoPtr_bar;

		// Token: 0x04006E37 RID: 28215
		private static readonly IntPtr NativeFieldInfoPtr_colorButtonPrefab;

		// Token: 0x04006E38 RID: 28216
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04006E39 RID: 28217
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionPurchased;

		// Token: 0x04006E3A RID: 28218
		private static readonly IntPtr NativeFieldInfoPtr_specificFeature;

		// Token: 0x04006E3B RID: 28219
		private static readonly IntPtr NativeFieldInfoPtr_selectionIndex;

		// Token: 0x04006E3C RID: 28220
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0;

		// Token: 0x04006E3D RID: 28221
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006E3E RID: 28222
		private static readonly IntPtr NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0;

		// Token: 0x04006E3F RID: 28223
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x04006E40 RID: 28224
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006E41 RID: 28225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC6 RID: 3014
		[ObfuscatedName("ScheduleOne.UI.Construction.Features.FI_ColorPicker+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDC6 RID: 56774 RVA: 0x003459F0 File Offset: 0x00343BF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr);
				FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "index");
				FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100683391);
				FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100683392);
			}

			// Token: 0x0600DDC7 RID: 56775 RVA: 0x00345A6C File Offset: 0x00343C6C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDC8 RID: 56776 RVA: 0x00345AA8 File Offset: 0x00343CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287358, XrefRangeEnd = 287360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDC9 RID: 56777 RVA: 0x0006C174 File Offset: 0x0006A374
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B5 RID: 17589
			// (get) Token: 0x0600DDCA RID: 56778 RVA: 0x00345ADC File Offset: 0x00343CDC
			// (set) Token: 0x0600DDCB RID: 56779 RVA: 0x0006C17D File Offset: 0x0006A37D
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170044B6 RID: 17590
			// (get) Token: 0x0600DDCC RID: 56780 RVA: 0x00345B04 File Offset: 0x00343D04
			// (set) Token: 0x0600DDCD RID: 56781 RVA: 0x0006C198 File Offset: 0x0006A398
			public unsafe FI_ColorPicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_ColorPicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009487 RID: 38023
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009488 RID: 38024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009489 RID: 38025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400948A RID: 38026
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
		}
	}
}
