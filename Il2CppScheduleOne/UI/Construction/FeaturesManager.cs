using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.Construction.Features;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x02000720 RID: 1824
	public class FeaturesManager : Singleton<FeaturesManager>
	{
		// Token: 0x0600A43B RID: 42043 RVA: 0x00292980 File Offset: 0x00290B80
		// Note: this type is marked as 'beforefieldinit'.
		static FeaturesManager()
		{
			Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "FeaturesManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr);
			FeaturesManager.NativeFieldInfoPtr_activeConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "activeConstructable");
			FeaturesManager.NativeFieldInfoPtr_selectedFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "selectedFeature");
			FeaturesManager.NativeFieldInfoPtr_featureIconsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIconsContainer");
			FeaturesManager.NativeFieldInfoPtr_featureMenuRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureMenuRect");
			FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureMenuTitleLabel");
			FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureInterfaceContainer");
			FeaturesManager.NativeFieldInfoPtr_featureIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIconPrefab");
			FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "currentFeatureInterface");
			FeaturesManager.NativeFieldInfoPtr_roofSetInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "roofSetInvisible");
			FeaturesManager.NativeFieldInfoPtr_featureIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, "featureIcons");
			FeaturesManager.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683373);
			FeaturesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683374);
			FeaturesManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683375);
			FeaturesManager.NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683376);
			FeaturesManager.NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683377);
			FeaturesManager.NativeMethodInfoPtr_DeselectFeature_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683378);
			FeaturesManager.NativeMethodInfoPtr_Activate_Public_Void_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683379);
			FeaturesManager.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683380);
			FeaturesManager.NativeMethodInfoPtr_ClearIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683381);
			FeaturesManager.NativeMethodInfoPtr_CreateIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683382);
			FeaturesManager.NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683383);
			FeaturesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr, 100683384);
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x00292B68 File Offset: 0x00290D68
		public unsafe bool isActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287176, XrefRangeEnd = 287180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x00292BA4 File Offset: 0x00290DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287180, XrefRangeEnd = 287184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeaturesManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x00292BE0 File Offset: 0x00290DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287184, XrefRangeEnd = 287190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x00292C14 File Offset: 0x00290E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287215, RefRangeEnd = 287216, XrefRangeStart = 287190, XrefRangeEnd = 287215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFeatureMenu(Feature feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x00292C58 File Offset: 0x00290E58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 287233, RefRangeEnd = 287238, XrefRangeStart = 287216, XrefRangeEnd = 287233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseFeatureMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x00292C8C File Offset: 0x00290E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287238, XrefRangeEnd = 287259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectFeature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_DeselectFeature_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x00292CC0 File Offset: 0x00290EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287259, XrefRangeEnd = 287262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(Constructable constructable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_Activate_Public_Void_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x00292D04 File Offset: 0x00290F04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287281, RefRangeEnd = 287284, XrefRangeStart = 287262, XrefRangeEnd = 287281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x00292D38 File Offset: 0x00290F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287284, XrefRangeEnd = 287296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_ClearIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x00292D6C File Offset: 0x00290F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287329, RefRangeEnd = 287331, XrefRangeStart = 287296, XrefRangeEnd = 287329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_CreateIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x00292DA0 File Offset: 0x00290FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287346, RefRangeEnd = 287348, XrefRangeStart = 287331, XrefRangeEnd = 287346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIconTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x00292DD4 File Offset: 0x00290FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287348, XrefRangeEnd = 287358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeaturesManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeaturesManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x00050EDE File Offset: 0x0004F0DE
		public FeaturesManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A449 RID: 42057 RVA: 0x00292E10 File Offset: 0x00291010
		// (set) Token: 0x0600A44A RID: 42058 RVA: 0x00050EE7 File Offset: 0x0004F0E7
		public unsafe Constructable activeConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_activeConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_activeConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x00292E40 File Offset: 0x00291040
		// (set) Token: 0x0600A44C RID: 42060 RVA: 0x00050F06 File Offset: 0x0004F106
		public unsafe Feature selectedFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_selectedFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_selectedFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A44D RID: 42061 RVA: 0x00292E70 File Offset: 0x00291070
		// (set) Token: 0x0600A44E RID: 42062 RVA: 0x00050F25 File Offset: 0x0004F125
		public unsafe RectTransform featureIconsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A44F RID: 42063 RVA: 0x00292EA0 File Offset: 0x002910A0
		// (set) Token: 0x0600A450 RID: 42064 RVA: 0x00050F44 File Offset: 0x0004F144
		public unsafe RectTransform featureMenuRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A451 RID: 42065 RVA: 0x00292ED0 File Offset: 0x002910D0
		// (set) Token: 0x0600A452 RID: 42066 RVA: 0x00050F63 File Offset: 0x0004F163
		public unsafe TextMeshProUGUI featureMenuTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureMenuTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x00292F00 File Offset: 0x00291100
		// (set) Token: 0x0600A454 RID: 42068 RVA: 0x00050F82 File Offset: 0x0004F182
		public unsafe RectTransform featureInterfaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureInterfaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600A455 RID: 42069 RVA: 0x00292F30 File Offset: 0x00291130
		// (set) Token: 0x0600A456 RID: 42070 RVA: 0x00050FA1 File Offset: 0x0004F1A1
		public unsafe GameObject featureIconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600A457 RID: 42071 RVA: 0x00292F60 File Offset: 0x00291160
		// (set) Token: 0x0600A458 RID: 42072 RVA: 0x00050FC0 File Offset: 0x0004F1C0
		public unsafe FI_Base currentFeatureInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_currentFeatureInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x00292F90 File Offset: 0x00291190
		// (set) Token: 0x0600A45A RID: 42074 RVA: 0x00050FDF File Offset: 0x0004F1DF
		public unsafe bool roofSetInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_roofSetInvisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_roofSetInvisible)) = value;
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x00292FB8 File Offset: 0x002911B8
		// (set) Token: 0x0600A45C RID: 42076 RVA: 0x00050FFA File Offset: 0x0004F1FA
		public unsafe List<FeatureIcon> featureIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FeatureIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeaturesManager.NativeFieldInfoPtr_featureIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E1C RID: 28188
		private static readonly IntPtr NativeFieldInfoPtr_activeConstructable;

		// Token: 0x04006E1D RID: 28189
		private static readonly IntPtr NativeFieldInfoPtr_selectedFeature;

		// Token: 0x04006E1E RID: 28190
		private static readonly IntPtr NativeFieldInfoPtr_featureIconsContainer;

		// Token: 0x04006E1F RID: 28191
		private static readonly IntPtr NativeFieldInfoPtr_featureMenuRect;

		// Token: 0x04006E20 RID: 28192
		private static readonly IntPtr NativeFieldInfoPtr_featureMenuTitleLabel;

		// Token: 0x04006E21 RID: 28193
		private static readonly IntPtr NativeFieldInfoPtr_featureInterfaceContainer;

		// Token: 0x04006E22 RID: 28194
		private static readonly IntPtr NativeFieldInfoPtr_featureIconPrefab;

		// Token: 0x04006E23 RID: 28195
		private static readonly IntPtr NativeFieldInfoPtr_currentFeatureInterface;

		// Token: 0x04006E24 RID: 28196
		private static readonly IntPtr NativeFieldInfoPtr_roofSetInvisible;

		// Token: 0x04006E25 RID: 28197
		private static readonly IntPtr NativeFieldInfoPtr_featureIcons;

		// Token: 0x04006E26 RID: 28198
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04006E27 RID: 28199
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006E28 RID: 28200
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006E29 RID: 28201
		private static readonly IntPtr NativeMethodInfoPtr_OpenFeatureMenu_Public_Void_Feature_0;

		// Token: 0x04006E2A RID: 28202
		private static readonly IntPtr NativeMethodInfoPtr_CloseFeatureMenu_Public_Void_0;

		// Token: 0x04006E2B RID: 28203
		private static readonly IntPtr NativeMethodInfoPtr_DeselectFeature_Public_Void_0;

		// Token: 0x04006E2C RID: 28204
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Constructable_0;

		// Token: 0x04006E2D RID: 28205
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04006E2E RID: 28206
		private static readonly IntPtr NativeMethodInfoPtr_ClearIcons_Private_Void_0;

		// Token: 0x04006E2F RID: 28207
		private static readonly IntPtr NativeMethodInfoPtr_CreateIcons_Private_Void_0;

		// Token: 0x04006E30 RID: 28208
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIconTransforms_Private_Void_0;

		// Token: 0x04006E31 RID: 28209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
