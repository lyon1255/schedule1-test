using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000651 RID: 1617
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x0600900B RID: 36875 RVA: 0x0025528C File Offset: 0x0025348C
		// Note: this type is marked as 'beforefieldinit'.
		static PickpocketScreen()
		{
			Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PickpocketScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr);
			PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "PICKPOCKET_XP");
			PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMaxWidth");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreaMinWidth");
			PickpocketScreen.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTime");
			PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SlideTimeMaxMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_ValueDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "ValueDivisor");
			PickpocketScreen.NativeFieldInfoPtr_Tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Tolerance");
			PickpocketScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Canvas");
			PickpocketScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Container");
			PickpocketScreen.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slots");
			PickpocketScreen.NativeFieldInfoPtr_GreenAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "GreenAreas");
			PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialAnimation");
			PickpocketScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "TutorialContainer");
			PickpocketScreen.NativeFieldInfoPtr_SliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "SliderContainer");
			PickpocketScreen.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "Slider");
			PickpocketScreen.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "InputPrompt");
			PickpocketScreen.NativeFieldInfoPtr_onFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onFail");
			PickpocketScreen.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onStop");
			PickpocketScreen.NativeFieldInfoPtr_onHitGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "onHitGreen");
			PickpocketScreen.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "npc");
			PickpocketScreen.NativeFieldInfoPtr_isSliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isSliding");
			PickpocketScreen.NativeFieldInfoPtr_slideDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideDirection");
			PickpocketScreen.NativeFieldInfoPtr_sliderPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "sliderPosition");
			PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "slideTimeMultiplier");
			PickpocketScreen.NativeFieldInfoPtr_isFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "isFail");
			PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681140);
			PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681141);
			PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681142);
			PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681143);
			PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681144);
			PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681145);
			PickpocketScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681146);
			PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681147);
			PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681148);
			PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681149);
			PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681150);
			PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681151);
			PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681152);
			PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681153);
			PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681154);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681155);
			PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681156);
			PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681157);
			PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, 100681158);
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600900C RID: 36876 RVA: 0x00255654 File Offset: 0x00253854
		// (set) Token: 0x0600900D RID: 36877 RVA: 0x00255690 File Offset: 0x00253890
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600900E RID: 36878 RVA: 0x002556D0 File Offset: 0x002538D0
		// (set) Token: 0x0600900F RID: 36879 RVA: 0x0025570C File Offset: 0x0025390C
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0025574C File Offset: 0x0025394C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260986, XrefRangeEnd = 261003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PickpocketScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x00255788 File Offset: 0x00253988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261109, RefRangeEnd = 261111, XrefRangeStart = 261003, XrefRangeEnd = 261109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(NPC _npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Open_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x002557CC File Offset: 0x002539CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261111, XrefRangeEnd = 261112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x00255810 File Offset: 0x00253A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261112, XrefRangeEnd = 261140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x00255844 File Offset: 0x00253A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261161, RefRangeEnd = 261162, XrefRangeStart = 261140, XrefRangeEnd = 261161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopArrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_StopArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x00255878 File Offset: 0x00253A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261171, RefRangeEnd = 261172, XrefRangeStart = 261162, XrefRangeEnd = 261171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked(int index, bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x002558C4 File Offset: 0x00253AC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261179, RefRangeEnd = 261182, XrefRangeStart = 261172, XrefRangeEnd = 261179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x00255904 File Offset: 0x00253B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261182, XrefRangeEnd = 261189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Fail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x00255938 File Offset: 0x00253B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261244, RefRangeEnd = 261245, XrefRangeStart = 261189, XrefRangeEnd = 261244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0025596C File Offset: 0x00253B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261245, XrefRangeEnd = 261249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x002559A0 File Offset: 0x00253BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261249, XrefRangeEnd = 261252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x002559D4 File Offset: 0x00253BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261254, RefRangeEnd = 261256, XrefRangeStart = 261252, XrefRangeEnd = 261254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedPosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x00255A20 File Offset: 0x00253C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261258, RefRangeEnd = 261260, XrefRangeStart = 261256, XrefRangeEnd = 261258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGreenAreaNormalizedWidth(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x00255A6C File Offset: 0x00253C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261260, XrefRangeEnd = 261263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PickpocketScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x00255AA8 File Offset: 0x00253CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261263, XrefRangeEnd = 261268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x000457FA File Offset: 0x000439FA
		public PickpocketScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x06009020 RID: 36896 RVA: 0x00255AE8 File Offset: 0x00253CE8
		// (set) Token: 0x06009021 RID: 36897 RVA: 0x00045803 File Offset: 0x00043A03
		public unsafe static int PICKPOCKET_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PickpocketScreen.NativeFieldInfoPtr_PICKPOCKET_XP, (void*)(&value));
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x06009022 RID: 36898 RVA: 0x00255B04 File Offset: 0x00253D04
		// (set) Token: 0x06009023 RID: 36899 RVA: 0x00045811 File Offset: 0x00043A11
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x00255B2C File Offset: 0x00253D2C
		// (set) Token: 0x06009025 RID: 36901 RVA: 0x0004582C File Offset: 0x00043A2C
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x06009026 RID: 36902 RVA: 0x00255B54 File Offset: 0x00253D54
		// (set) Token: 0x06009027 RID: 36903 RVA: 0x00045847 File Offset: 0x00043A47
		public unsafe float GreenAreaMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMaxWidth)) = value;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x06009028 RID: 36904 RVA: 0x00255B7C File Offset: 0x00253D7C
		// (set) Token: 0x06009029 RID: 36905 RVA: 0x00045862 File Offset: 0x00043A62
		public unsafe float GreenAreaMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreaMinWidth)) = value;
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600902A RID: 36906 RVA: 0x00255BA4 File Offset: 0x00253DA4
		// (set) Token: 0x0600902B RID: 36907 RVA: 0x0004587D File Offset: 0x00043A7D
		public unsafe float SlideTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTime)) = value;
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600902C RID: 36908 RVA: 0x00255BCC File Offset: 0x00253DCC
		// (set) Token: 0x0600902D RID: 36909 RVA: 0x00045898 File Offset: 0x00043A98
		public unsafe float SlideTimeMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SlideTimeMaxMultiplier)) = value;
			}
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600902E RID: 36910 RVA: 0x00255BF4 File Offset: 0x00253DF4
		// (set) Token: 0x0600902F RID: 36911 RVA: 0x000458B3 File Offset: 0x00043AB3
		public unsafe float ValueDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_ValueDivisor)) = value;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x06009030 RID: 36912 RVA: 0x00255C1C File Offset: 0x00253E1C
		// (set) Token: 0x06009031 RID: 36913 RVA: 0x000458CE File Offset: 0x00043ACE
		public unsafe float Tolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Tolerance)) = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x06009032 RID: 36914 RVA: 0x00255C44 File Offset: 0x00253E44
		// (set) Token: 0x06009033 RID: 36915 RVA: 0x000458E9 File Offset: 0x00043AE9
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x00255C74 File Offset: 0x00253E74
		// (set) Token: 0x06009035 RID: 36917 RVA: 0x00045908 File Offset: 0x00043B08
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x06009036 RID: 36918 RVA: 0x00255CA4 File Offset: 0x00253EA4
		// (set) Token: 0x06009037 RID: 36919 RVA: 0x00045927 File Offset: 0x00043B27
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x06009038 RID: 36920 RVA: 0x00255CD4 File Offset: 0x00253ED4
		// (set) Token: 0x06009039 RID: 36921 RVA: 0x00045946 File Offset: 0x00043B46
		public unsafe Il2CppReferenceArray<RectTransform> GreenAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_GreenAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600903A RID: 36922 RVA: 0x00255D04 File Offset: 0x00253F04
		// (set) Token: 0x0600903B RID: 36923 RVA: 0x00045965 File Offset: 0x00043B65
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600903C RID: 36924 RVA: 0x00255D34 File Offset: 0x00253F34
		// (set) Token: 0x0600903D RID: 36925 RVA: 0x00045984 File Offset: 0x00043B84
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x00255D64 File Offset: 0x00253F64
		// (set) Token: 0x0600903F RID: 36927 RVA: 0x000459A3 File Offset: 0x00043BA3
		public unsafe RectTransform SliderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_SliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x00255D94 File Offset: 0x00253F94
		// (set) Token: 0x06009041 RID: 36929 RVA: 0x000459C2 File Offset: 0x00043BC2
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x06009042 RID: 36930 RVA: 0x00255DC4 File Offset: 0x00253FC4
		// (set) Token: 0x06009043 RID: 36931 RVA: 0x000459E1 File Offset: 0x00043BE1
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_InputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x06009044 RID: 36932 RVA: 0x00255DF4 File Offset: 0x00253FF4
		// (set) Token: 0x06009045 RID: 36933 RVA: 0x00045A00 File Offset: 0x00043C00
		public unsafe UnityEvent onFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x06009046 RID: 36934 RVA: 0x00255E24 File Offset: 0x00254024
		// (set) Token: 0x06009047 RID: 36935 RVA: 0x00045A1F File Offset: 0x00043C1F
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x06009048 RID: 36936 RVA: 0x00255E54 File Offset: 0x00254054
		// (set) Token: 0x06009049 RID: 36937 RVA: 0x00045A3E File Offset: 0x00043C3E
		public unsafe UnityEvent onHitGreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_onHitGreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0600904A RID: 36938 RVA: 0x00255E84 File Offset: 0x00254084
		// (set) Token: 0x0600904B RID: 36939 RVA: 0x00045A5D File Offset: 0x00043C5D
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0600904C RID: 36940 RVA: 0x00255EB4 File Offset: 0x002540B4
		// (set) Token: 0x0600904D RID: 36941 RVA: 0x00045A7C File Offset: 0x00043C7C
		public unsafe bool isSliding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isSliding)) = value;
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0600904E RID: 36942 RVA: 0x00255EDC File Offset: 0x002540DC
		// (set) Token: 0x0600904F RID: 36943 RVA: 0x00045A97 File Offset: 0x00043C97
		public unsafe int slideDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideDirection)) = value;
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x06009050 RID: 36944 RVA: 0x00255F04 File Offset: 0x00254104
		// (set) Token: 0x06009051 RID: 36945 RVA: 0x00045AB2 File Offset: 0x00043CB2
		public unsafe float sliderPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_sliderPosition)) = value;
			}
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x06009052 RID: 36946 RVA: 0x00255F2C File Offset: 0x0025412C
		// (set) Token: 0x06009053 RID: 36947 RVA: 0x00045ACD File Offset: 0x00043CCD
		public unsafe float slideTimeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_slideTimeMultiplier)) = value;
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x06009054 RID: 36948 RVA: 0x00255F54 File Offset: 0x00254154
		// (set) Token: 0x06009055 RID: 36949 RVA: 0x00045AE8 File Offset: 0x00043CE8
		public unsafe bool isFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.NativeFieldInfoPtr_isFail)) = value;
			}
		}

		// Token: 0x0400616E RID: 24942
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_XP;

		// Token: 0x0400616F RID: 24943
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006170 RID: 24944
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04006171 RID: 24945
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreaMaxWidth;

		// Token: 0x04006172 RID: 24946
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreaMinWidth;

		// Token: 0x04006173 RID: 24947
		private static readonly IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x04006174 RID: 24948
		private static readonly IntPtr NativeFieldInfoPtr_SlideTimeMaxMultiplier;

		// Token: 0x04006175 RID: 24949
		private static readonly IntPtr NativeFieldInfoPtr_ValueDivisor;

		// Token: 0x04006176 RID: 24950
		private static readonly IntPtr NativeFieldInfoPtr_Tolerance;

		// Token: 0x04006177 RID: 24951
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006178 RID: 24952
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006179 RID: 24953
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x0400617A RID: 24954
		private static readonly IntPtr NativeFieldInfoPtr_GreenAreas;

		// Token: 0x0400617B RID: 24955
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x0400617C RID: 24956
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x0400617D RID: 24957
		private static readonly IntPtr NativeFieldInfoPtr_SliderContainer;

		// Token: 0x0400617E RID: 24958
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x0400617F RID: 24959
		private static readonly IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x04006180 RID: 24960
		private static readonly IntPtr NativeFieldInfoPtr_onFail;

		// Token: 0x04006181 RID: 24961
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04006182 RID: 24962
		private static readonly IntPtr NativeFieldInfoPtr_onHitGreen;

		// Token: 0x04006183 RID: 24963
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04006184 RID: 24964
		private static readonly IntPtr NativeFieldInfoPtr_isSliding;

		// Token: 0x04006185 RID: 24965
		private static readonly IntPtr NativeFieldInfoPtr_slideDirection;

		// Token: 0x04006186 RID: 24966
		private static readonly IntPtr NativeFieldInfoPtr_sliderPosition;

		// Token: 0x04006187 RID: 24967
		private static readonly IntPtr NativeFieldInfoPtr_slideTimeMultiplier;

		// Token: 0x04006188 RID: 24968
		private static readonly IntPtr NativeFieldInfoPtr_isFail;

		// Token: 0x04006189 RID: 24969
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400618A RID: 24970
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400618B RID: 24971
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x0400618C RID: 24972
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400618D RID: 24973
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400618E RID: 24974
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_NPC_0;

		// Token: 0x0400618F RID: 24975
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006190 RID: 24976
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006191 RID: 24977
		private static readonly IntPtr NativeMethodInfoPtr_StopArrow_Private_Void_0;

		// Token: 0x04006192 RID: 24978
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Void_Int32_Boolean_0;

		// Token: 0x04006193 RID: 24979
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredSlot_Private_ItemSlotUI_0;

		// Token: 0x04006194 RID: 24980
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Private_Void_0;

		// Token: 0x04006195 RID: 24981
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006196 RID: 24982
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04006197 RID: 24983
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04006198 RID: 24984
		private static readonly IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedPosition_Private_Single_Int32_0;

		// Token: 0x04006199 RID: 24985
		private static readonly IntPtr NativeMethodInfoPtr_GetGreenAreaNormalizedWidth_Private_Single_Int32_0;

		// Token: 0x0400619A RID: 24986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400619B RID: 24987
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B38 RID: 2872
		[ObfuscatedName("ScheduleOne.UI.PickpocketScreen+<<Fail>g__FailCoroutine|40_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D83A RID: 55354 RVA: 0x00335BCC File Offset: 0x00333DCC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique()
			{
				Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PickpocketScreen>.NativeClassPtr, "<<Fail>g__FailCoroutine|40_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>1__state");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>2__current");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, "<>4__this");
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681159);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681160);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681161);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681162);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681163);
				PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr, 100681164);
			}

			// Token: 0x0600D83B RID: 55355 RVA: 0x00335CAC File Offset: 0x00333EAC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D83C RID: 55356 RVA: 0x00335CF4 File Offset: 0x00333EF4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D83D RID: 55357 RVA: 0x00335D28 File Offset: 0x00333F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260976, XrefRangeEnd = 260981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700430B RID: 17163
			// (get) Token: 0x0600D83E RID: 55358 RVA: 0x00335D64 File Offset: 0x00333F64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D83F RID: 55359 RVA: 0x00335DA4 File Offset: 0x00333FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260981, XrefRangeEnd = 260986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700430C RID: 17164
			// (get) Token: 0x0600D840 RID: 55360 RVA: 0x00335DD8 File Offset: 0x00333FD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D841 RID: 55361 RVA: 0x000694EF File Offset: 0x000676EF
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004308 RID: 17160
			// (get) Token: 0x0600D842 RID: 55362 RVA: 0x00335E18 File Offset: 0x00334018
			// (set) Token: 0x0600D843 RID: 55363 RVA: 0x000694F8 File Offset: 0x000676F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004309 RID: 17161
			// (get) Token: 0x0600D844 RID: 55364 RVA: 0x00335E40 File Offset: 0x00334040
			// (set) Token: 0x0600D845 RID: 55365 RVA: 0x00069513 File Offset: 0x00067713
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430A RID: 17162
			// (get) Token: 0x0600D846 RID: 55366 RVA: 0x00335E70 File Offset: 0x00334070
			// (set) Token: 0x0600D847 RID: 55367 RVA: 0x00069532 File Offset: 0x00067732
			public unsafe PickpocketScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickpocketScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PickpocketScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009152 RID: 37202
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009153 RID: 37203
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009154 RID: 37204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009155 RID: 37205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009156 RID: 37206
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009157 RID: 37207
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009158 RID: 37208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009159 RID: 37209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400915A RID: 37210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
