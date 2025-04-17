using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000676 RID: 1654
	public class WorldspacePopupCanvas : MonoBehaviour
	{
		// Token: 0x060093B7 RID: 37815 RVA: 0x0025FDC0 File Offset: 0x0025DFC0
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupCanvas()
		{
			Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr);
			WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WORLDSPACE_ICON_SCALE_MULTIPLIER");
			WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WorldspaceContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudIconContainerPrefab");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeWorldspaceUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeHUDUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "popupsWithUI");
			WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681607);
			WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681608);
			WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681609);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681610);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681611);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681612);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681613);
			WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100681614);
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x0025FF1C File Offset: 0x0025E11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265517, XrefRangeEnd = 265629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x0025FF50 File Offset: 0x0025E150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265629, XrefRangeEnd = 265727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x0025FF84 File Offset: 0x0025E184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265740, RefRangeEnd = 265742, XrefRangeStart = 265727, XrefRangeEnd = 265740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldCreateUI(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x0025FFD4 File Offset: 0x0025E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265742, XrefRangeEnd = 265754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr3) : null;
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00260024 File Offset: 0x0025E224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265782, RefRangeEnd = 265783, XrefRangeStart = 265754, XrefRangeEnd = 265782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x00260074 File Offset: 0x0025E274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265783, XrefRangeEnd = 265801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x002600B8 File Offset: 0x0025E2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265827, RefRangeEnd = 265828, XrefRangeStart = 265801, XrefRangeEnd = 265827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x002600FC File Offset: 0x0025E2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265828, XrefRangeEnd = 265850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x00047A04 File Offset: 0x00045C04
		public WorldspacePopupCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x00260138 File Offset: 0x0025E338
		// (set) Token: 0x060093C2 RID: 37826 RVA: 0x00047A0D File Offset: 0x00045C0D
		public unsafe static float WORLDSPACE_ICON_SCALE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x00260154 File Offset: 0x0025E354
		// (set) Token: 0x060093C4 RID: 37828 RVA: 0x00047A1B File Offset: 0x00045C1B
		public unsafe RectTransform WorldspaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x00260184 File Offset: 0x0025E384
		// (set) Token: 0x060093C6 RID: 37830 RVA: 0x00047A3A File Offset: 0x00045C3A
		public unsafe RectTransform HudContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x002601B4 File Offset: 0x0025E3B4
		// (set) Token: 0x060093C8 RID: 37832 RVA: 0x00047A59 File Offset: 0x00045C59
		public unsafe GameObject HudIconContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x060093C9 RID: 37833 RVA: 0x002601E4 File Offset: 0x0025E3E4
		// (set) Token: 0x060093CA RID: 37834 RVA: 0x00047A78 File Offset: 0x00045C78
		public unsafe List<WorldspacePopupUI> activeWorldspaceUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x060093CB RID: 37835 RVA: 0x00260214 File Offset: 0x0025E414
		// (set) Token: 0x060093CC RID: 37836 RVA: 0x00047A97 File Offset: 0x00045C97
		public unsafe List<RectTransform> activeHUDUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x060093CD RID: 37837 RVA: 0x00260244 File Offset: 0x0025E444
		// (set) Token: 0x060093CE RID: 37838 RVA: 0x00047AB6 File Offset: 0x00045CB6
		public unsafe List<WorldspacePopup> popupsWithUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063B0 RID: 25520
		private static readonly IntPtr NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER;

		// Token: 0x040063B1 RID: 25521
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceContainer;

		// Token: 0x040063B2 RID: 25522
		private static readonly IntPtr NativeFieldInfoPtr_HudContainer;

		// Token: 0x040063B3 RID: 25523
		private static readonly IntPtr NativeFieldInfoPtr_HudIconContainerPrefab;

		// Token: 0x040063B4 RID: 25524
		private static readonly IntPtr NativeFieldInfoPtr_activeWorldspaceUIs;

		// Token: 0x040063B5 RID: 25525
		private static readonly IntPtr NativeFieldInfoPtr_activeHUDUIs;

		// Token: 0x040063B6 RID: 25526
		private static readonly IntPtr NativeFieldInfoPtr_popupsWithUI;

		// Token: 0x040063B7 RID: 25527
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040063B8 RID: 25528
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040063B9 RID: 25529
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0;

		// Token: 0x040063BA RID: 25530
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0;

		// Token: 0x040063BB RID: 25531
		private static readonly IntPtr NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0;

		// Token: 0x040063BC RID: 25532
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x040063BD RID: 25533
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x040063BE RID: 25534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
