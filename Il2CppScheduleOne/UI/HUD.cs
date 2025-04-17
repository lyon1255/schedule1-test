using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000640 RID: 1600
	public class HUD : Singleton<HUD>
	{
		// Token: 0x06008D8A RID: 36234 RVA: 0x0024DED4 File Offset: 0x0024C0D4
		// Note: this type is marked as 'beforefieldinit'.
		static HUD()
		{
			Il2CppClassPointerStore<HUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HUD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD>.NativeClassPtr);
			HUD.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvas");
			HUD.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvasRect");
			HUD.NativeFieldInfoPtr_crosshair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "crosshair");
			HUD.NativeFieldInfoPtr_blackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlay");
			HUD.NativeFieldInfoPtr_radialIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicator");
			HUD.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "raycaster");
			HUD.NativeFieldInfoPtr_topScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText");
			HUD.NativeFieldInfoPtr_topScreenText_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText_Background");
			HUD.NativeFieldInfoPtr_fpsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "fpsLabel");
			HUD.NativeFieldInfoPtr_cashSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotContainer");
			HUD.NativeFieldInfoPtr_cashSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotUI");
			HUD.NativeFieldInfoPtr_onlineBalanceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceContainer");
			HUD.NativeFieldInfoPtr_onlineBalanceSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceSlotUI");
			HUD.NativeFieldInfoPtr_managementSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotContainer");
			HUD.NativeFieldInfoPtr_managementSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotUI");
			HUD.NativeFieldInfoPtr_HotbarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "HotbarContainer");
			HUD.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SlotContainer");
			HUD.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlot");
			HUD.NativeFieldInfoPtr_discardSlotFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlotFill");
			HUD.NativeFieldInfoPtr_selectedItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "selectedItemLabel");
			HUD.NativeFieldInfoPtr_QuestEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryContainer");
			HUD.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryTitle");
			HUD.NativeFieldInfoPtr_CrimeStatusUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrimeStatusUI");
			HUD.NativeFieldInfoPtr_OnlineBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "OnlineBalanceDisplay");
			HUD.NativeFieldInfoPtr_SafeBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SafeBalanceDisplay");
			HUD.NativeFieldInfoPtr_CrosshairText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrosshairText");
			HUD.NativeFieldInfoPtr_UnreadMessagesPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "UnreadMessagesPrompt");
			HUD.NativeFieldInfoPtr_SleepPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SleepPrompt");
			HUD.NativeFieldInfoPtr_CurfewPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CurfewPrompt");
			HUD.NativeFieldInfoPtr_RedGreenGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "RedGreenGradient");
			HUD.NativeFieldInfoPtr_SampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SampleSize");
			HUD.NativeFieldInfoPtr__previousFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "_previousFPS");
			HUD.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "eventSystem");
			HUD.NativeFieldInfoPtr_blackOverlayFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlayFade");
			HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicatorSetThisFrame");
			HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680895);
			HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680896);
			HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680897);
			HUD.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680898);
			HUD.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680899);
			HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680900);
			HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680901);
			HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680902);
			HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680903);
			HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680904);
			HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680905);
			HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680906);
			HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680907);
			HUD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100680908);
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x0024E2D8 File Offset: 0x0024C4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257968, XrefRangeEnd = 257981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8C RID: 36236 RVA: 0x0024E314 File Offset: 0x0024C514
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 257984, RefRangeEnd = 258016, XrefRangeStart = 257981, XrefRangeEnd = 257984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrosshairVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x0024E354 File Offset: 0x0024C554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258016, XrefRangeEnd = 258024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x0024E3A0 File Offset: 0x0024C5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258024, XrefRangeEnd = 258025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x0024E3DC File Offset: 0x0024C5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258025, XrefRangeEnd = 258060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x0024E410 File Offset: 0x0024C610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258060, XrefRangeEnd = 258067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuestEntryTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x0024E444 File Offset: 0x0024C644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258086, RefRangeEnd = 258087, XrefRangeStart = 258067, XrefRangeEnd = 258086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x0024E478 File Offset: 0x0024C678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258087, XrefRangeEnd = 258092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x0024E4B4 File Offset: 0x0024C6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258092, XrefRangeEnd = 258093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x0024E4F0 File Offset: 0x0024C6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258093, XrefRangeEnd = 258098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x0024E54C File Offset: 0x0024C74C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258101, RefRangeEnd = 258106, XrefRangeStart = 258098, XrefRangeEnd = 258101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowRadialIndicator(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x0024E58C File Offset: 0x0024C78C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 258111, RefRangeEnd = 258120, XrefRangeStart = 258106, XrefRangeEnd = 258111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTopScreenText(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x0024E5D0 File Offset: 0x0024C7D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 258123, RefRangeEnd = 258130, XrefRangeStart = 258120, XrefRangeEnd = 258123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTopScreenText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x0024E604 File Offset: 0x0024C804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258130, XrefRangeEnd = 258140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HUD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00043EE6 File Offset: 0x000420E6
		public HUD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06008D9A RID: 36250 RVA: 0x0024E640 File Offset: 0x0024C840
		// (set) Token: 0x06008D9B RID: 36251 RVA: 0x00043EEF File Offset: 0x000420EF
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x06008D9C RID: 36252 RVA: 0x0024E670 File Offset: 0x0024C870
		// (set) Token: 0x06008D9D RID: 36253 RVA: 0x00043F0E File Offset: 0x0004210E
		public unsafe RectTransform canvasRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x06008D9E RID: 36254 RVA: 0x0024E6A0 File Offset: 0x0024C8A0
		// (set) Token: 0x06008D9F RID: 36255 RVA: 0x00043F2D File Offset: 0x0004212D
		public unsafe Image crosshair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x0024E6D0 File Offset: 0x0024C8D0
		// (set) Token: 0x06008DA1 RID: 36257 RVA: 0x00043F4C File Offset: 0x0004214C
		public unsafe Image blackOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x06008DA2 RID: 36258 RVA: 0x0024E700 File Offset: 0x0024C900
		// (set) Token: 0x06008DA3 RID: 36259 RVA: 0x00043F6B File Offset: 0x0004216B
		public unsafe Image radialIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x0024E730 File Offset: 0x0024C930
		// (set) Token: 0x06008DA5 RID: 36261 RVA: 0x00043F8A File Offset: 0x0004218A
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x06008DA6 RID: 36262 RVA: 0x0024E760 File Offset: 0x0024C960
		// (set) Token: 0x06008DA7 RID: 36263 RVA: 0x00043FA9 File Offset: 0x000421A9
		public unsafe TextMeshProUGUI topScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x06008DA8 RID: 36264 RVA: 0x0024E790 File Offset: 0x0024C990
		// (set) Token: 0x06008DA9 RID: 36265 RVA: 0x00043FC8 File Offset: 0x000421C8
		public unsafe RectTransform topScreenText_Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06008DAA RID: 36266 RVA: 0x0024E7C0 File Offset: 0x0024C9C0
		// (set) Token: 0x06008DAB RID: 36267 RVA: 0x00043FE7 File Offset: 0x000421E7
		public unsafe Text fpsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06008DAC RID: 36268 RVA: 0x0024E7F0 File Offset: 0x0024C9F0
		// (set) Token: 0x06008DAD RID: 36269 RVA: 0x00044006 File Offset: 0x00042206
		public unsafe RectTransform cashSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x0024E820 File Offset: 0x0024CA20
		// (set) Token: 0x06008DAF RID: 36271 RVA: 0x00044025 File Offset: 0x00042225
		public unsafe RectTransform cashSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x06008DB0 RID: 36272 RVA: 0x0024E850 File Offset: 0x0024CA50
		// (set) Token: 0x06008DB1 RID: 36273 RVA: 0x00044044 File Offset: 0x00042244
		public unsafe RectTransform onlineBalanceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x0024E880 File Offset: 0x0024CA80
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x00044063 File Offset: 0x00042263
		public unsafe RectTransform onlineBalanceSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x0024E8B0 File Offset: 0x0024CAB0
		// (set) Token: 0x06008DB5 RID: 36277 RVA: 0x00044082 File Offset: 0x00042282
		public unsafe RectTransform managementSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x06008DB6 RID: 36278 RVA: 0x0024E8E0 File Offset: 0x0024CAE0
		// (set) Token: 0x06008DB7 RID: 36279 RVA: 0x000440A1 File Offset: 0x000422A1
		public unsafe ItemSlotUI managementSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x0024E910 File Offset: 0x0024CB10
		// (set) Token: 0x06008DB9 RID: 36281 RVA: 0x000440C0 File Offset: 0x000422C0
		public unsafe RectTransform HotbarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x06008DBA RID: 36282 RVA: 0x0024E940 File Offset: 0x0024CB40
		// (set) Token: 0x06008DBB RID: 36283 RVA: 0x000440DF File Offset: 0x000422DF
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x06008DBC RID: 36284 RVA: 0x0024E970 File Offset: 0x0024CB70
		// (set) Token: 0x06008DBD RID: 36285 RVA: 0x000440FE File Offset: 0x000422FE
		public unsafe ItemSlotUI discardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x06008DBE RID: 36286 RVA: 0x0024E9A0 File Offset: 0x0024CBA0
		// (set) Token: 0x06008DBF RID: 36287 RVA: 0x0004411D File Offset: 0x0004231D
		public unsafe Image discardSlotFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x0024E9D0 File Offset: 0x0024CBD0
		// (set) Token: 0x06008DC1 RID: 36289 RVA: 0x0004413C File Offset: 0x0004233C
		public unsafe TextMeshProUGUI selectedItemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x0024EA00 File Offset: 0x0024CC00
		// (set) Token: 0x06008DC3 RID: 36291 RVA: 0x0004415B File Offset: 0x0004235B
		public unsafe RectTransform QuestEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x0024EA30 File Offset: 0x0024CC30
		// (set) Token: 0x06008DC5 RID: 36293 RVA: 0x0004417A File Offset: 0x0004237A
		public unsafe TextMeshProUGUI QuestEntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x0024EA60 File Offset: 0x0024CC60
		// (set) Token: 0x06008DC7 RID: 36295 RVA: 0x00044199 File Offset: 0x00042399
		public unsafe CrimeStatusUI CrimeStatusUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x06008DC8 RID: 36296 RVA: 0x0024EA90 File Offset: 0x0024CC90
		// (set) Token: 0x06008DC9 RID: 36297 RVA: 0x000441B8 File Offset: 0x000423B8
		public unsafe BalanceDisplay OnlineBalanceDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x06008DCA RID: 36298 RVA: 0x0024EAC0 File Offset: 0x0024CCC0
		// (set) Token: 0x06008DCB RID: 36299 RVA: 0x000441D7 File Offset: 0x000423D7
		public unsafe BalanceDisplay SafeBalanceDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SafeBalanceDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SafeBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x06008DCC RID: 36300 RVA: 0x0024EAF0 File Offset: 0x0024CCF0
		// (set) Token: 0x06008DCD RID: 36301 RVA: 0x000441F6 File Offset: 0x000423F6
		public unsafe CrosshairText CrosshairText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrosshairText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x06008DCE RID: 36302 RVA: 0x0024EB20 File Offset: 0x0024CD20
		// (set) Token: 0x06008DCF RID: 36303 RVA: 0x00044215 File Offset: 0x00042415
		public unsafe RectTransform UnreadMessagesPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x06008DD0 RID: 36304 RVA: 0x0024EB50 File Offset: 0x0024CD50
		// (set) Token: 0x06008DD1 RID: 36305 RVA: 0x00044234 File Offset: 0x00042434
		public unsafe TextMeshProUGUI SleepPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x06008DD2 RID: 36306 RVA: 0x0024EB80 File Offset: 0x0024CD80
		// (set) Token: 0x06008DD3 RID: 36307 RVA: 0x00044253 File Offset: 0x00042453
		public unsafe TextMeshProUGUI CurfewPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x06008DD4 RID: 36308 RVA: 0x0024EBB0 File Offset: 0x0024CDB0
		// (set) Token: 0x06008DD5 RID: 36309 RVA: 0x00044272 File Offset: 0x00042472
		public unsafe Gradient RedGreenGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x06008DD6 RID: 36310 RVA: 0x0024EBE0 File Offset: 0x0024CDE0
		// (set) Token: 0x06008DD7 RID: 36311 RVA: 0x00044291 File Offset: 0x00042491
		public unsafe int SampleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize)) = value;
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x06008DD8 RID: 36312 RVA: 0x0024EC08 File Offset: 0x0024CE08
		// (set) Token: 0x06008DD9 RID: 36313 RVA: 0x000442AC File Offset: 0x000424AC
		public unsafe List<float> _previousFPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x0024EC38 File Offset: 0x0024CE38
		// (set) Token: 0x06008DDB RID: 36315 RVA: 0x000442CB File Offset: 0x000424CB
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x06008DDC RID: 36316 RVA: 0x0024EC68 File Offset: 0x0024CE68
		// (set) Token: 0x06008DDD RID: 36317 RVA: 0x000442EA File Offset: 0x000424EA
		public unsafe Coroutine blackOverlayFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x06008DDE RID: 36318 RVA: 0x0024EC98 File Offset: 0x0024CE98
		// (set) Token: 0x06008DDF RID: 36319 RVA: 0x00044309 File Offset: 0x00042509
		public unsafe bool radialIndicatorSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame)) = value;
			}
		}

		// Token: 0x04005FE2 RID: 24546
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005FE3 RID: 24547
		private static readonly IntPtr NativeFieldInfoPtr_canvasRect;

		// Token: 0x04005FE4 RID: 24548
		private static readonly IntPtr NativeFieldInfoPtr_crosshair;

		// Token: 0x04005FE5 RID: 24549
		private static readonly IntPtr NativeFieldInfoPtr_blackOverlay;

		// Token: 0x04005FE6 RID: 24550
		private static readonly IntPtr NativeFieldInfoPtr_radialIndicator;

		// Token: 0x04005FE7 RID: 24551
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04005FE8 RID: 24552
		private static readonly IntPtr NativeFieldInfoPtr_topScreenText;

		// Token: 0x04005FE9 RID: 24553
		private static readonly IntPtr NativeFieldInfoPtr_topScreenText_Background;

		// Token: 0x04005FEA RID: 24554
		private static readonly IntPtr NativeFieldInfoPtr_fpsLabel;

		// Token: 0x04005FEB RID: 24555
		private static readonly IntPtr NativeFieldInfoPtr_cashSlotContainer;

		// Token: 0x04005FEC RID: 24556
		private static readonly IntPtr NativeFieldInfoPtr_cashSlotUI;

		// Token: 0x04005FED RID: 24557
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceContainer;

		// Token: 0x04005FEE RID: 24558
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceSlotUI;

		// Token: 0x04005FEF RID: 24559
		private static readonly IntPtr NativeFieldInfoPtr_managementSlotContainer;

		// Token: 0x04005FF0 RID: 24560
		private static readonly IntPtr NativeFieldInfoPtr_managementSlotUI;

		// Token: 0x04005FF1 RID: 24561
		private static readonly IntPtr NativeFieldInfoPtr_HotbarContainer;

		// Token: 0x04005FF2 RID: 24562
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04005FF3 RID: 24563
		private static readonly IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x04005FF4 RID: 24564
		private static readonly IntPtr NativeFieldInfoPtr_discardSlotFill;

		// Token: 0x04005FF5 RID: 24565
		private static readonly IntPtr NativeFieldInfoPtr_selectedItemLabel;

		// Token: 0x04005FF6 RID: 24566
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryContainer;

		// Token: 0x04005FF7 RID: 24567
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x04005FF8 RID: 24568
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusUI;

		// Token: 0x04005FF9 RID: 24569
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalanceDisplay;

		// Token: 0x04005FFA RID: 24570
		private static readonly IntPtr NativeFieldInfoPtr_SafeBalanceDisplay;

		// Token: 0x04005FFB RID: 24571
		private static readonly IntPtr NativeFieldInfoPtr_CrosshairText;

		// Token: 0x04005FFC RID: 24572
		private static readonly IntPtr NativeFieldInfoPtr_UnreadMessagesPrompt;

		// Token: 0x04005FFD RID: 24573
		private static readonly IntPtr NativeFieldInfoPtr_SleepPrompt;

		// Token: 0x04005FFE RID: 24574
		private static readonly IntPtr NativeFieldInfoPtr_CurfewPrompt;

		// Token: 0x04005FFF RID: 24575
		private static readonly IntPtr NativeFieldInfoPtr_RedGreenGradient;

		// Token: 0x04006000 RID: 24576
		private static readonly IntPtr NativeFieldInfoPtr_SampleSize;

		// Token: 0x04006001 RID: 24577
		private static readonly IntPtr NativeFieldInfoPtr__previousFPS;

		// Token: 0x04006002 RID: 24578
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006003 RID: 24579
		private static readonly IntPtr NativeFieldInfoPtr_blackOverlayFade;

		// Token: 0x04006004 RID: 24580
		private static readonly IntPtr NativeFieldInfoPtr_radialIndicatorSetThisFrame;

		// Token: 0x04006005 RID: 24581
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006006 RID: 24582
		private static readonly IntPtr NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0;

		// Token: 0x04006007 RID: 24583
		private static readonly IntPtr NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0;

		// Token: 0x04006008 RID: 24584
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006009 RID: 24585
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400600A RID: 24586
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0;

		// Token: 0x0400600B RID: 24587
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFPS_Private_Void_0;

		// Token: 0x0400600C RID: 24588
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageFPS_Private_Single_0;

		// Token: 0x0400600D RID: 24589
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400600E RID: 24590
		private static readonly IntPtr NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0;

		// Token: 0x0400600F RID: 24591
		private static readonly IntPtr NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0;

		// Token: 0x04006010 RID: 24592
		private static readonly IntPtr NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0;

		// Token: 0x04006011 RID: 24593
		private static readonly IntPtr NativeMethodInfoPtr_HideTopScreenText_Public_Void_0;

		// Token: 0x04006012 RID: 24594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B28 RID: 2856
		[ObfuscatedName("ScheduleOne.UI.HUD+<FadeBlackOverlay>d__43")]
		public sealed class _FadeBlackOverlay_d__43 : Il2CppSystem.Object
		{
			// Token: 0x0600D7A9 RID: 55209 RVA: 0x003342FC File Offset: 0x003324FC
			// Note: this type is marked as 'beforefieldinit'.
			static _FadeBlackOverlay_d__43()
			{
				Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUD>.NativeClassPtr, "<FadeBlackOverlay>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr);
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>1__state");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>2__current");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "visible");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<>4__this");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "fadeTime");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<startAlpha>5__2");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<endAlpha>5__3");
				HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, "<i>5__4");
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680909);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680910);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680911);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680912);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680913);
				HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr, 100680914);
			}

			// Token: 0x0600D7AA RID: 55210 RVA: 0x00334440 File Offset: 0x00332640
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FadeBlackOverlay_d__43(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__43>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7AB RID: 55211 RVA: 0x00334488 File Offset: 0x00332688
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7AC RID: 55212 RVA: 0x003344BC File Offset: 0x003326BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257947, XrefRangeEnd = 257963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042DF RID: 17119
			// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x003344F8 File Offset: 0x003326F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7AE RID: 55214 RVA: 0x00334538 File Offset: 0x00332738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257963, XrefRangeEnd = 257968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042E0 RID: 17120
			// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x0033456C File Offset: 0x0033276C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7B0 RID: 55216 RVA: 0x00069004 File Offset: 0x00067204
			public _FadeBlackOverlay_d__43(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D7 RID: 17111
			// (get) Token: 0x0600D7B1 RID: 55217 RVA: 0x003345AC File Offset: 0x003327AC
			// (set) Token: 0x0600D7B2 RID: 55218 RVA: 0x0006900D File Offset: 0x0006720D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042D8 RID: 17112
			// (get) Token: 0x0600D7B3 RID: 55219 RVA: 0x003345D4 File Offset: 0x003327D4
			// (set) Token: 0x0600D7B4 RID: 55220 RVA: 0x00069028 File Offset: 0x00067228
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D9 RID: 17113
			// (get) Token: 0x0600D7B5 RID: 55221 RVA: 0x00334604 File Offset: 0x00332804
			// (set) Token: 0x0600D7B6 RID: 55222 RVA: 0x00069047 File Offset: 0x00067247
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x170042DA RID: 17114
			// (get) Token: 0x0600D7B7 RID: 55223 RVA: 0x0033462C File Offset: 0x0033282C
			// (set) Token: 0x0600D7B8 RID: 55224 RVA: 0x00069062 File Offset: 0x00067262
			public unsafe HUD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HUD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DB RID: 17115
			// (get) Token: 0x0600D7B9 RID: 55225 RVA: 0x0033465C File Offset: 0x0033285C
			// (set) Token: 0x0600D7BA RID: 55226 RVA: 0x00069081 File Offset: 0x00067281
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x170042DC RID: 17116
			// (get) Token: 0x0600D7BB RID: 55227 RVA: 0x00334684 File Offset: 0x00332884
			// (set) Token: 0x0600D7BC RID: 55228 RVA: 0x0006909C File Offset: 0x0006729C
			public unsafe float _startAlpha_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__startAlpha_5__2)) = value;
				}
			}

			// Token: 0x170042DD RID: 17117
			// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x003346AC File Offset: 0x003328AC
			// (set) Token: 0x0600D7BE RID: 55230 RVA: 0x000690B7 File Offset: 0x000672B7
			public unsafe float _endAlpha_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__endAlpha_5__3)) = value;
				}
			}

			// Token: 0x170042DE RID: 17118
			// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x003346D4 File Offset: 0x003328D4
			// (set) Token: 0x0600D7C0 RID: 55232 RVA: 0x000690D2 File Offset: 0x000672D2
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__43.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040090F3 RID: 37107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090F4 RID: 37108
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090F5 RID: 37109
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x040090F6 RID: 37110
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090F7 RID: 37111
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x040090F8 RID: 37112
			private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

			// Token: 0x040090F9 RID: 37113
			private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__3;

			// Token: 0x040090FA RID: 37114
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040090FB RID: 37115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090FC RID: 37116
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090FD RID: 37117
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090FE RID: 37118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090FF RID: 37119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009100 RID: 37120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
