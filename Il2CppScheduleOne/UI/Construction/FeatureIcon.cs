using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x0200071F RID: 1823
	public class FeatureIcon : MonoBehaviour
	{
		// Token: 0x0600A41D RID: 42013 RVA: 0x00292394 File Offset: 0x00290594
		// Note: this type is marked as 'beforefieldinit'.
		static FeatureIcon()
		{
			Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "FeatureIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr);
			FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "selectedFeatureIcon");
			FeatureIcon.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "rectTransform");
			FeatureIcon.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "icon");
			FeatureIcon.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "text");
			FeatureIcon.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "background");
			FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "<feature>k__BackingField");
			FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "<isSelected>k__BackingField");
			FeatureIcon.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "hovered");
			FeatureIcon.NativeMethodInfoPtr_get_feature_Public_get_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683361);
			FeatureIcon.NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683362);
			FeatureIcon.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683363);
			FeatureIcon.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683364);
			FeatureIcon.NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683365);
			FeatureIcon.NativeMethodInfoPtr_UpdateTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683366);
			FeatureIcon.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683367);
			FeatureIcon.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683368);
			FeatureIcon.NativeMethodInfoPtr_UpdateColors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683369);
			FeatureIcon.NativeMethodInfoPtr_PointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683370);
			FeatureIcon.NativeMethodInfoPtr_PointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683371);
			FeatureIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683372);
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A41E RID: 42014 RVA: 0x00292554 File Offset: 0x00290754
		// (set) Token: 0x0600A41F RID: 42015 RVA: 0x00292594 File Offset: 0x00290794
		public unsafe Feature feature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_get_feature_Public_get_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A420 RID: 42016 RVA: 0x002925D8 File Offset: 0x002907D8
		// (set) Token: 0x0600A421 RID: 42017 RVA: 0x00292614 File Offset: 0x00290814
		public unsafe bool isSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x00292654 File Offset: 0x00290854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287099, XrefRangeEnd = 287104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignFeature(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x00292698 File Offset: 0x00290898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287133, RefRangeEnd = 287134, XrefRangeStart = 287104, XrefRangeEnd = 287133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_UpdateTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x002926CC File Offset: 0x002908CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287134, XrefRangeEnd = 287144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x00292700 File Offset: 0x00290900
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287167, RefRangeEnd = 287170, XrefRangeStart = 287144, XrefRangeEnd = 287167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSelected(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x00292740 File Offset: 0x00290940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287170, RefRangeEnd = 287171, XrefRangeStart = 287170, XrefRangeEnd = 287170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_UpdateColors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x00292774 File Offset: 0x00290974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287171, XrefRangeEnd = 287174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_PointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x002927A8 File Offset: 0x002909A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287174, XrefRangeEnd = 287176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_PointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x002927DC File Offset: 0x002909DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeatureIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x00050DF2 File Offset: 0x0004EFF2
		public FeatureIcon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A42B RID: 42027 RVA: 0x00292818 File Offset: 0x00290A18
		// (set) Token: 0x0600A42C RID: 42028 RVA: 0x00050DFB File Offset: 0x0004EFFB
		public unsafe static FeatureIcon selectedFeatureIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureIcon>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A42D RID: 42029 RVA: 0x00292840 File Offset: 0x00290A40
		// (set) Token: 0x0600A42E RID: 42030 RVA: 0x00050E0D File Offset: 0x0004F00D
		public unsafe RectTransform rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A42F RID: 42031 RVA: 0x00292870 File Offset: 0x00290A70
		// (set) Token: 0x0600A430 RID: 42032 RVA: 0x00050E2C File Offset: 0x0004F02C
		public unsafe Image icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A431 RID: 42033 RVA: 0x002928A0 File Offset: 0x00290AA0
		// (set) Token: 0x0600A432 RID: 42034 RVA: 0x00050E4B File Offset: 0x0004F04B
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600A433 RID: 42035 RVA: 0x002928D0 File Offset: 0x00290AD0
		// (set) Token: 0x0600A434 RID: 42036 RVA: 0x00050E6A File Offset: 0x0004F06A
		public unsafe Image background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600A435 RID: 42037 RVA: 0x00292900 File Offset: 0x00290B00
		// (set) Token: 0x0600A436 RID: 42038 RVA: 0x00050E89 File Offset: 0x0004F089
		public unsafe Feature _feature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600A437 RID: 42039 RVA: 0x00292930 File Offset: 0x00290B30
		// (set) Token: 0x0600A438 RID: 42040 RVA: 0x00050EA8 File Offset: 0x0004F0A8
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A439 RID: 42041 RVA: 0x00292958 File Offset: 0x00290B58
		// (set) Token: 0x0600A43A RID: 42042 RVA: 0x00050EC3 File Offset: 0x0004F0C3
		public unsafe bool hovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_hovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_hovered)) = value;
			}
		}

		// Token: 0x04006E08 RID: 28168
		private static readonly IntPtr NativeFieldInfoPtr_selectedFeatureIcon;

		// Token: 0x04006E09 RID: 28169
		private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

		// Token: 0x04006E0A RID: 28170
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x04006E0B RID: 28171
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04006E0C RID: 28172
		private static readonly IntPtr NativeFieldInfoPtr_background;

		// Token: 0x04006E0D RID: 28173
		private static readonly IntPtr NativeFieldInfoPtr__feature_k__BackingField;

		// Token: 0x04006E0E RID: 28174
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x04006E0F RID: 28175
		private static readonly IntPtr NativeFieldInfoPtr_hovered;

		// Token: 0x04006E10 RID: 28176
		private static readonly IntPtr NativeMethodInfoPtr_get_feature_Public_get_Feature_0;

		// Token: 0x04006E11 RID: 28177
		private static readonly IntPtr NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0;

		// Token: 0x04006E12 RID: 28178
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x04006E13 RID: 28179
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04006E14 RID: 28180
		private static readonly IntPtr NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0;

		// Token: 0x04006E15 RID: 28181
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_0;

		// Token: 0x04006E16 RID: 28182
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006E17 RID: 28183
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0;

		// Token: 0x04006E18 RID: 28184
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Private_Void_0;

		// Token: 0x04006E19 RID: 28185
		private static readonly IntPtr NativeMethodInfoPtr_PointerEnter_Public_Void_0;

		// Token: 0x04006E1A RID: 28186
		private static readonly IntPtr NativeMethodInfoPtr_PointerExit_Public_Void_0;

		// Token: 0x04006E1B RID: 28187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
