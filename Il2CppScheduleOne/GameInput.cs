using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x0200016A RID: 362
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x06001D29 RID: 7465 RVA: 0x000CB044 File Offset: 0x000C9244
		// Note: this type is marked as 'beforefieldinit'.
		static GameInput()
		{
			Il2CppClassPointerStore<GameInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "GameInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput>.NativeClassPtr);
			GameInput.NativeFieldInfoPtr_exitListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "exitListeners");
			GameInput.NativeFieldInfoPtr_PlayerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "PlayerInput");
			GameInput.NativeFieldInfoPtr_IsTyping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "IsTyping");
			GameInput.NativeFieldInfoPtr_MotionAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "MotionAxis");
			GameInput.NativeFieldInfoPtr_buttonsDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDownThisFrame");
			GameInput.NativeFieldInfoPtr_buttonsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDown");
			GameInput.NativeFieldInfoPtr_buttonsUpThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsUpThisFrame");
			GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666596);
			GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666597);
			GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666598);
			GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666599);
			GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666600);
			GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666601);
			GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666602);
			GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666603);
			GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666604);
			GameInput.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666605);
			GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666606);
			GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666607);
			GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666608);
			GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666609);
			GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666610);
			GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666611);
			GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666612);
			GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666613);
			GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666614);
			GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666615);
			GameInput.NativeMethodInfoPtr_OnEscape_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666616);
			GameInput.NativeMethodInfoPtr_OnBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666617);
			GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666618);
			GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666619);
			GameInput.NativeMethodInfoPtr_OnTogglePhone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666620);
			GameInput.NativeMethodInfoPtr_OnToggleLights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666621);
			GameInput.NativeMethodInfoPtr_OnHandbrake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666622);
			GameInput.NativeMethodInfoPtr_OnRotateLeft_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666623);
			GameInput.NativeMethodInfoPtr_OnRotateRight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666624);
			GameInput.NativeMethodInfoPtr_OnManagementMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666625);
			GameInput.NativeMethodInfoPtr_OnOpenMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666626);
			GameInput.NativeMethodInfoPtr_OnOpenJournal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666627);
			GameInput.NativeMethodInfoPtr_OnOpenTexts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666628);
			GameInput.NativeMethodInfoPtr_OnQuickMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666629);
			GameInput.NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666630);
			GameInput.NativeMethodInfoPtr_OnViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666631);
			GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666632);
			GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666633);
			GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666634);
			GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666635);
			GameInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666636);
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x000CB434 File Offset: 0x000C9634
		public unsafe static Vector2 MouseDelta
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 105053, RefRangeEnd = 105072, XrefRangeStart = 105047, XrefRangeEnd = 105053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000CB464 File Offset: 0x000C9664
		public unsafe static Vector3 MousePosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 105073, RefRangeEnd = 105077, XrefRangeStart = 105072, XrefRangeEnd = 105073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000CB494 File Offset: 0x000C9694
		public unsafe static float MouseScrollDelta
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 105080, RefRangeEnd = 105088, XrefRangeStart = 105077, XrefRangeEnd = 105080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x000CB4C4 File Offset: 0x000C96C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105088, XrefRangeEnd = 105091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000CB500 File Offset: 0x000C9700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105091, XrefRangeEnd = 105127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x000CB53C File Offset: 0x000C973C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105127, XrefRangeEnd = 105146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000CB57C File Offset: 0x000C977C
		[CallerCount(80)]
		[CachedScanResults(RefRangeStart = 105154, RefRangeEnd = 105234, XrefRangeStart = 105146, XrefRangeEnd = 105154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000CB5BC File Offset: 0x000C97BC
		[CallerCount(116)]
		[CachedScanResults(RefRangeStart = 105242, RefRangeEnd = 105358, XrefRangeStart = 105234, XrefRangeEnd = 105242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000CB5FC File Offset: 0x000C97FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105366, RefRangeEnd = 105367, XrefRangeStart = 105358, XrefRangeEnd = 105366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buttonCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000CB63C File Offset: 0x000C983C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105367, XrefRangeEnd = 105402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x000CB678 File Offset: 0x000C9878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105417, RefRangeEnd = 105419, XrefRangeStart = 105402, XrefRangeEnd = 105417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000CB6B8 File Offset: 0x000C98B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105419, XrefRangeEnd = 105420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000CB6EC File Offset: 0x000C98EC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 105448, RefRangeEnd = 105458, XrefRangeStart = 105420, XrefRangeEnd = 105448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000CB720 File Offset: 0x000C9920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105458, XrefRangeEnd = 105533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMotion(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000CB764 File Offset: 0x000C9964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105543, RefRangeEnd = 105544, XrefRangeStart = 105533, XrefRangeEnd = 105543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrimaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000CB798 File Offset: 0x000C9998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105554, RefRangeEnd = 105555, XrefRangeStart = 105544, XrefRangeEnd = 105554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000CB7CC File Offset: 0x000C99CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105555, XrefRangeEnd = 105565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000CB800 File Offset: 0x000C9A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105565, XrefRangeEnd = 105575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000CB834 File Offset: 0x000C9A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105575, XrefRangeEnd = 105585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x000CB868 File Offset: 0x000C9A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105585, XrefRangeEnd = 105595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSprint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x000CB89C File Offset: 0x000C9A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105595, XrefRangeEnd = 105605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEscape()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnEscape_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x000CB8D0 File Offset: 0x000C9AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105605, XrefRangeEnd = 105615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000CB904 File Offset: 0x000C9B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105615, XrefRangeEnd = 105625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x000CB938 File Offset: 0x000C9B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105625, XrefRangeEnd = 105635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x000CB96C File Offset: 0x000C9B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105635, XrefRangeEnd = 105645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTogglePhone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTogglePhone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000CB9A0 File Offset: 0x000C9BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105645, XrefRangeEnd = 105655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnToggleLights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x000CB9D4 File Offset: 0x000C9BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105655, XrefRangeEnd = 105665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnHandbrake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x000CBA08 File Offset: 0x000C9C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105665, XrefRangeEnd = 105675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotateLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnRotateLeft_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000CBA3C File Offset: 0x000C9C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105675, XrefRangeEnd = 105685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotateRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnRotateRight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000CBA70 File Offset: 0x000C9C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105685, XrefRangeEnd = 105695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnManagementMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnManagementMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x000CBAA4 File Offset: 0x000C9CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105695, XrefRangeEnd = 105705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000CBAD8 File Offset: 0x000C9CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105705, XrefRangeEnd = 105715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenJournal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenJournal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000CBB0C File Offset: 0x000C9D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105715, XrefRangeEnd = 105725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenTexts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenTexts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x000CBB40 File Offset: 0x000C9D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105725, XrefRangeEnd = 105735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnQuickMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000CBB74 File Offset: 0x000C9D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105735, XrefRangeEnd = 105745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000CBBA8 File Offset: 0x000C9DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105745, XrefRangeEnd = 105755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000CBBDC File Offset: 0x000C9DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105755, XrefRangeEnd = 105765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000CBC10 File Offset: 0x000C9E10
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 105795, RefRangeEnd = 105860, XrefRangeStart = 105765, XrefRangeEnd = 105795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x000CBC54 File Offset: 0x000C9E54
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 105878, RefRangeEnd = 105889, XrefRangeStart = 105860, XrefRangeEnd = 105878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x000CBC8C File Offset: 0x000C9E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105893, RefRangeEnd = 105894, XrefRangeStart = 105889, XrefRangeEnd = 105893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction GetAction(GameInput.ButtonCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000CBCD8 File Offset: 0x000C9ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105894, XrefRangeEnd = 105914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInput() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00010929 File Offset: 0x0000EB29
		public GameInput(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x000CBD14 File Offset: 0x000C9F14
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00010932 File Offset: 0x0000EB32
		public unsafe static List<GameInput.ExitListener> exitListeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_exitListeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ExitListener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_exitListeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000CBD3C File Offset: 0x000C9F3C
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00010944 File Offset: 0x0000EB44
		public unsafe PlayerInput PlayerInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000CBD6C File Offset: 0x000C9F6C
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00010963 File Offset: 0x0000EB63
		public unsafe static bool IsTyping
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_IsTyping, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_IsTyping, (void*)(&value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x000CBD88 File Offset: 0x000C9F88
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00010971 File Offset: 0x0000EB71
		public unsafe static Vector2 MotionAxis
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000CBDA4 File Offset: 0x000C9FA4
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0001097F File Offset: 0x0000EB7F
		public unsafe List<GameInput.ButtonCode> buttonsDownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000CBDD4 File Offset: 0x000C9FD4
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0001099E File Offset: 0x0000EB9E
		public unsafe List<GameInput.ButtonCode> buttonsDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000CBE04 File Offset: 0x000CA004
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x000109BD File Offset: 0x0000EBBD
		public unsafe List<GameInput.ButtonCode> buttonsUpThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeFieldInfoPtr_exitListeners;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInput;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr_IsTyping;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr_MotionAxis;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr_buttonsDownThisFrame;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeFieldInfoPtr_buttonsDown;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeFieldInfoPtr_buttonsUpThisFrame;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitType_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_OnJump_Private_Void_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_OnCrouch_Private_Void_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_OnSprint_Private_Void_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_OnEscape_Private_Void_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_OnBack_Private_Void_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Private_Void_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_OnTogglePhone_Private_Void_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleLights_Private_Void_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_OnHandbrake_Private_Void_0;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_OnRotateLeft_Private_Void_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_OnRotateRight_Private_Void_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_OnManagementMode_Private_Void_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_OnOpenMap_Private_Void_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_OnOpenJournal_Private_Void_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_OnOpenTexts_Private_Void_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_OnQuickMove_Private_Void_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_OnViewAvatar_Private_Void_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_OnReload_Private_Void_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008A2 RID: 2210
		[OriginalName("Assembly-CSharp.dll", "", "ButtonCode")]
		public enum ButtonCode
		{
			// Token: 0x040083D9 RID: 33753
			PrimaryClick,
			// Token: 0x040083DA RID: 33754
			SecondaryClick,
			// Token: 0x040083DB RID: 33755
			TertiaryClick,
			// Token: 0x040083DC RID: 33756
			Forward,
			// Token: 0x040083DD RID: 33757
			Backward,
			// Token: 0x040083DE RID: 33758
			Left,
			// Token: 0x040083DF RID: 33759
			Right,
			// Token: 0x040083E0 RID: 33760
			Jump,
			// Token: 0x040083E1 RID: 33761
			Crouch,
			// Token: 0x040083E2 RID: 33762
			Sprint,
			// Token: 0x040083E3 RID: 33763
			Escape,
			// Token: 0x040083E4 RID: 33764
			Back,
			// Token: 0x040083E5 RID: 33765
			Interact,
			// Token: 0x040083E6 RID: 33766
			Submit,
			// Token: 0x040083E7 RID: 33767
			TogglePhone,
			// Token: 0x040083E8 RID: 33768
			ToggleLights,
			// Token: 0x040083E9 RID: 33769
			Handbrake,
			// Token: 0x040083EA RID: 33770
			RotateLeft,
			// Token: 0x040083EB RID: 33771
			RotateRight,
			// Token: 0x040083EC RID: 33772
			ManagementMode,
			// Token: 0x040083ED RID: 33773
			OpenMap,
			// Token: 0x040083EE RID: 33774
			OpenJournal,
			// Token: 0x040083EF RID: 33775
			OpenTexts,
			// Token: 0x040083F0 RID: 33776
			QuickMove,
			// Token: 0x040083F1 RID: 33777
			ToggleFlashlight,
			// Token: 0x040083F2 RID: 33778
			ViewAvatar,
			// Token: 0x040083F3 RID: 33779
			Reload
		}

		// Token: 0x020008A3 RID: 2211
		public class ExitListener : Il2CppSystem.Object
		{
			// Token: 0x0600C2B8 RID: 49848 RVA: 0x002F8B40 File Offset: 0x002F6D40
			// Note: this type is marked as 'beforefieldinit'.
			static ExitListener()
			{
				Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitListener");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr);
				GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "listenerFunction");
				GameInput.ExitListener.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "priority");
				GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, 100666638);
			}

			// Token: 0x0600C2B9 RID: 49849 RVA: 0x002F8BA8 File Offset: 0x002F6DA8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitListener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2BA RID: 49850 RVA: 0x0005EC15 File Offset: 0x0005CE15
			public ExitListener(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CCF RID: 15567
			// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x002F8BE4 File Offset: 0x002F6DE4
			// (set) Token: 0x0600C2BC RID: 49852 RVA: 0x0005EC1E File Offset: 0x0005CE1E
			public unsafe GameInput.ExitDelegate listenerFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.ExitDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD0 RID: 15568
			// (get) Token: 0x0600C2BD RID: 49853 RVA: 0x002F8C14 File Offset: 0x002F6E14
			// (set) Token: 0x0600C2BE RID: 49854 RVA: 0x0005EC3D File Offset: 0x0005CE3D
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x040083F4 RID: 33780
			private static readonly IntPtr NativeFieldInfoPtr_listenerFunction;

			// Token: 0x040083F5 RID: 33781
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x040083F6 RID: 33782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008A4 RID: 2212
		public sealed class ExitDelegate : MulticastDelegate
		{
			// Token: 0x0600C2BF RID: 49855 RVA: 0x002F8C3C File Offset: 0x002F6E3C
			// Note: this type is marked as 'beforefieldinit'.
			static ExitDelegate()
			{
				Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitDelegate");
				GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666639);
				GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666640);
				GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666641);
				GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666642);
			}

			// Token: 0x0600C2C0 RID: 49856 RVA: 0x002F8CB0 File Offset: 0x002F6EB0
			[CallerCount(257)]
			[CachedScanResults(RefRangeStart = 104784, RefRangeEnd = 105041, XrefRangeStart = 104775, XrefRangeEnd = 104784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2C1 RID: 49857 RVA: 0x002F8D0C File Offset: 0x002F6F0C
			[CallerCount(0)]
			public unsafe void Invoke(ExitAction exitAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2C2 RID: 49858 RVA: 0x002F8D50 File Offset: 0x002F6F50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ExitAction exitAction, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C2C3 RID: 49859 RVA: 0x002F8DC4 File Offset: 0x002F6FC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2C4 RID: 49860 RVA: 0x0005EC58 File Offset: 0x0005CE58
			public ExitDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C2C5 RID: 49861 RVA: 0x0005EC61 File Offset: 0x0005CE61
			public static implicit operator GameInput.ExitDelegate(Action<ExitAction> A_0)
			{
				return DelegateSupport.ConvertDelegate<GameInput.ExitDelegate>(A_0);
			}

			// Token: 0x0600C2C6 RID: 49862 RVA: 0x0005EC69 File Offset: 0x0005CE69
			public static GameInput.ExitDelegate operator +(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<GameInput.ExitDelegate>();
			}

			// Token: 0x0600C2C7 RID: 49863 RVA: 0x0005EC77 File Offset: 0x0005CE77
			public static GameInput.ExitDelegate operator -(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<GameInput.ExitDelegate>();
				}
				return result;
			}

			// Token: 0x040083F7 RID: 33783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040083F8 RID: 33784
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0;

			// Token: 0x040083F9 RID: 33785
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0;

			// Token: 0x040083FA RID: 33786
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008A5 RID: 2213
		[ObfuscatedName("ScheduleOne.GameInput+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C2C8 RID: 49864 RVA: 0x002F8E08 File Offset: 0x002F7008
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr);
				GameInput.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9");
				GameInput.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9__17_0");
				GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100666644);
				GameInput.__c.NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100666645);
			}

			// Token: 0x0600C2C9 RID: 49865 RVA: 0x002F8E84 File Offset: 0x002F7084
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2CA RID: 49866 RVA: 0x002F8EC0 File Offset: 0x002F70C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105041, XrefRangeEnd = 105047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2CB RID: 49867 RVA: 0x0005EC88 File Offset: 0x0005CE88
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD1 RID: 15569
			// (get) Token: 0x0600C2CC RID: 49868 RVA: 0x002F8EF4 File Offset: 0x002F70F4
			// (set) Token: 0x0600C2CD RID: 49869 RVA: 0x0005EC91 File Offset: 0x0005CE91
			public unsafe static GameInput.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD2 RID: 15570
			// (get) Token: 0x0600C2CE RID: 49870 RVA: 0x002F8F1C File Offset: 0x002F711C
			// (set) Token: 0x0600C2CF RID: 49871 RVA: 0x0005ECA3 File Offset: 0x0005CEA3
			public unsafe static UnityAction __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083FB RID: 33787
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040083FC RID: 33788
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x040083FD RID: 33789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083FE RID: 33790
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0;
		}
	}
}
