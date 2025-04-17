using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000675 RID: 1653
	public class WorldspacePopup : MonoBehaviour
	{
		// Token: 0x06009392 RID: 37778 RVA: 0x0025F7E8 File Offset: 0x0025D9E8
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopup()
		{
			Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr);
			WorldspacePopup.NativeFieldInfoPtr_ActivePopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ActivePopups");
			WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "CurrentFillLevel");
			WorldspacePopup.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIPrefab");
			WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "DisplayOnHUD");
			WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ScaleWithDistance");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceOffset");
			WorldspacePopup.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "Range");
			WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "SizeMultiplier");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUIIcon");
			WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUICanvasGroup");
			WorldspacePopup.NativeFieldInfoPtr_UIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIs");
			WorldspacePopup.NativeFieldInfoPtr_popupCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "popupCoroutine");
			WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681591);
			WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681592);
			WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681593);
			WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681594);
			WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681595);
			WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681596);
			WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100681598);
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x0025F9BC File Offset: 0x0025DBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265430, XrefRangeEnd = 265443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x0025F9F0 File Offset: 0x0025DBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265443, XrefRangeEnd = 265451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x0025FA24 File Offset: 0x0025DC24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 265477, RefRangeEnd = 265480, XrefRangeStart = 265451, XrefRangeEnd = 265477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateUI(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr3) : null;
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x0025FA74 File Offset: 0x0025DC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265480, XrefRangeEnd = 265495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x0025FAA8 File Offset: 0x0025DCA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265503, RefRangeEnd = 265504, XrefRangeStart = 265495, XrefRangeEnd = 265503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Popup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x0025FADC File Offset: 0x0025DCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265504, XrefRangeEnd = 265512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x0025FB18 File Offset: 0x0025DD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265512, XrefRangeEnd = 265517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x0004786E File Offset: 0x00045A6E
		public WorldspacePopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x0025FB58 File Offset: 0x0025DD58
		// (set) Token: 0x0600939C RID: 37788 RVA: 0x00047877 File Offset: 0x00045A77
		public unsafe static List<WorldspacePopup> ActivePopups
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x0025FB80 File Offset: 0x0025DD80
		// (set) Token: 0x0600939E RID: 37790 RVA: 0x00047889 File Offset: 0x00045A89
		public unsafe float CurrentFillLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel)) = value;
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600939F RID: 37791 RVA: 0x0025FBA8 File Offset: 0x0025DDA8
		// (set) Token: 0x060093A0 RID: 37792 RVA: 0x000478A4 File Offset: 0x00045AA4
		public unsafe WorldspacePopupUI UIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x060093A1 RID: 37793 RVA: 0x0025FBD8 File Offset: 0x0025DDD8
		// (set) Token: 0x060093A2 RID: 37794 RVA: 0x000478C3 File Offset: 0x00045AC3
		public unsafe bool DisplayOnHUD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD)) = value;
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x060093A3 RID: 37795 RVA: 0x0025FC00 File Offset: 0x0025DE00
		// (set) Token: 0x060093A4 RID: 37796 RVA: 0x000478DE File Offset: 0x00045ADE
		public unsafe bool ScaleWithDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance)) = value;
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x060093A5 RID: 37797 RVA: 0x0025FC28 File Offset: 0x0025DE28
		// (set) Token: 0x060093A6 RID: 37798 RVA: 0x000478F9 File Offset: 0x00045AF9
		public unsafe Vector3 WorldspaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset)) = value;
			}
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x060093A7 RID: 37799 RVA: 0x0025FC50 File Offset: 0x0025DE50
		// (set) Token: 0x060093A8 RID: 37800 RVA: 0x00047914 File Offset: 0x00045B14
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x060093A9 RID: 37801 RVA: 0x0025FC78 File Offset: 0x0025DE78
		// (set) Token: 0x060093AA RID: 37802 RVA: 0x0004792F File Offset: 0x00045B2F
		public unsafe float SizeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier)) = value;
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x060093AB RID: 37803 RVA: 0x0025FCA0 File Offset: 0x0025DEA0
		// (set) Token: 0x060093AC RID: 37804 RVA: 0x0004794A File Offset: 0x00045B4A
		public unsafe WorldspacePopupUI WorldspaceUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x060093AD RID: 37805 RVA: 0x0025FCD0 File Offset: 0x0025DED0
		// (set) Token: 0x060093AE RID: 37806 RVA: 0x00047969 File Offset: 0x00045B69
		public unsafe RectTransform HUDUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x060093AF RID: 37807 RVA: 0x0025FD00 File Offset: 0x0025DF00
		// (set) Token: 0x060093B0 RID: 37808 RVA: 0x00047988 File Offset: 0x00045B88
		public unsafe WorldspacePopupUI HUDUIIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x060093B1 RID: 37809 RVA: 0x0025FD30 File Offset: 0x0025DF30
		// (set) Token: 0x060093B2 RID: 37810 RVA: 0x000479A7 File Offset: 0x00045BA7
		public unsafe CanvasGroup HUDUICanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x0025FD60 File Offset: 0x0025DF60
		// (set) Token: 0x060093B4 RID: 37812 RVA: 0x000479C6 File Offset: 0x00045BC6
		public unsafe List<WorldspacePopupUI> UIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x0025FD90 File Offset: 0x0025DF90
		// (set) Token: 0x060093B6 RID: 37814 RVA: 0x000479E5 File Offset: 0x00045BE5
		public unsafe Coroutine popupCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400639B RID: 25499
		private static readonly IntPtr NativeFieldInfoPtr_ActivePopups;

		// Token: 0x0400639C RID: 25500
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillLevel;

		// Token: 0x0400639D RID: 25501
		private static readonly IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x0400639E RID: 25502
		private static readonly IntPtr NativeFieldInfoPtr_DisplayOnHUD;

		// Token: 0x0400639F RID: 25503
		private static readonly IntPtr NativeFieldInfoPtr_ScaleWithDistance;

		// Token: 0x040063A0 RID: 25504
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceOffset;

		// Token: 0x040063A1 RID: 25505
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x040063A2 RID: 25506
		private static readonly IntPtr NativeFieldInfoPtr_SizeMultiplier;

		// Token: 0x040063A3 RID: 25507
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUI;

		// Token: 0x040063A4 RID: 25508
		private static readonly IntPtr NativeFieldInfoPtr_HUDUI;

		// Token: 0x040063A5 RID: 25509
		private static readonly IntPtr NativeFieldInfoPtr_HUDUIIcon;

		// Token: 0x040063A6 RID: 25510
		private static readonly IntPtr NativeFieldInfoPtr_HUDUICanvasGroup;

		// Token: 0x040063A7 RID: 25511
		private static readonly IntPtr NativeFieldInfoPtr_UIs;

		// Token: 0x040063A8 RID: 25512
		private static readonly IntPtr NativeFieldInfoPtr_popupCoroutine;

		// Token: 0x040063A9 RID: 25513
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040063AA RID: 25514
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040063AB RID: 25515
		private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0;

		// Token: 0x040063AC RID: 25516
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040063AD RID: 25517
		private static readonly IntPtr NativeMethodInfoPtr_Popup_Public_Void_0;

		// Token: 0x040063AE RID: 25518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040063AF RID: 25519
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B56 RID: 2902
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<<Popup>g__PopupCoroutine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D9E6 RID: 55782 RVA: 0x0033AC04 File Offset: 0x00338E04
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique()
			{
				Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<<Popup>g__PopupCoroutine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681599);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681600);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681601);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681602);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681603);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100681604);
			}

			// Token: 0x0600D9E7 RID: 55783 RVA: 0x0033AD0C File Offset: 0x00338F0C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9E8 RID: 55784 RVA: 0x0033AD54 File Offset: 0x00338F54
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9E9 RID: 55785 RVA: 0x0033AD88 File Offset: 0x00338F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265417, XrefRangeEnd = 265421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043A0 RID: 17312
			// (get) Token: 0x0600D9EA RID: 55786 RVA: 0x0033ADC4 File Offset: 0x00338FC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9EB RID: 55787 RVA: 0x0033AE04 File Offset: 0x00339004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265421, XrefRangeEnd = 265426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043A1 RID: 17313
			// (get) Token: 0x0600D9EC RID: 55788 RVA: 0x0033AE38 File Offset: 0x00339038
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9ED RID: 55789 RVA: 0x0006A1F1 File Offset: 0x000683F1
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700439B RID: 17307
			// (get) Token: 0x0600D9EE RID: 55790 RVA: 0x0033AE78 File Offset: 0x00339078
			// (set) Token: 0x0600D9EF RID: 55791 RVA: 0x0006A1FA File Offset: 0x000683FA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700439C RID: 17308
			// (get) Token: 0x0600D9F0 RID: 55792 RVA: 0x0033AEA0 File Offset: 0x003390A0
			// (set) Token: 0x0600D9F1 RID: 55793 RVA: 0x0006A215 File Offset: 0x00068415
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439D RID: 17309
			// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x0033AED0 File Offset: 0x003390D0
			// (set) Token: 0x0600D9F3 RID: 55795 RVA: 0x0006A234 File Offset: 0x00068434
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439E RID: 17310
			// (get) Token: 0x0600D9F4 RID: 55796 RVA: 0x0033AF00 File Offset: 0x00339100
			// (set) Token: 0x0600D9F5 RID: 55797 RVA: 0x0006A253 File Offset: 0x00068453
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x1700439F RID: 17311
			// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x0033AF28 File Offset: 0x00339128
			// (set) Token: 0x0600D9F7 RID: 55799 RVA: 0x0006A26E File Offset: 0x0006846E
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009253 RID: 37459
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009254 RID: 37460
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009255 RID: 37461
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009256 RID: 37462
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04009257 RID: 37463
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009258 RID: 37464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009259 RID: 37465
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400925A RID: 37466
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400925B RID: 37467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400925C RID: 37468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400925D RID: 37469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B57 RID: 2903
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D9F8 RID: 55800 RVA: 0x0033AF50 File Offset: 0x00339150
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr);
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "newUI");
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100681605);
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100681606);
			}

			// Token: 0x0600D9F9 RID: 55801 RVA: 0x0033AFCC File Offset: 0x003391CC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9FA RID: 55802 RVA: 0x0033B008 File Offset: 0x00339208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265426, XrefRangeEnd = 265430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9FB RID: 55803 RVA: 0x0006A289 File Offset: 0x00068489
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A2 RID: 17314
			// (get) Token: 0x0600D9FC RID: 55804 RVA: 0x0033B03C File Offset: 0x0033923C
			// (set) Token: 0x0600D9FD RID: 55805 RVA: 0x0006A292 File Offset: 0x00068492
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A3 RID: 17315
			// (get) Token: 0x0600D9FE RID: 55806 RVA: 0x0033B06C File Offset: 0x0033926C
			// (set) Token: 0x0600D9FF RID: 55807 RVA: 0x0006A2B1 File Offset: 0x000684B1
			public unsafe WorldspacePopupUI newUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400925E RID: 37470
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400925F RID: 37471
			private static readonly IntPtr NativeFieldInfoPtr_newUI;

			// Token: 0x04009260 RID: 37472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009261 RID: 37473
			private static readonly IntPtr NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0;
		}
	}
}
