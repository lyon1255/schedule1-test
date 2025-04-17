using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E2 RID: 994
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x06004F23 RID: 20259 RVA: 0x0017AFFC File Offset: 0x001791FC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCamera()
		{
			Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr);
			PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CAMERA_SHAKE_MULTIPLIER");
			PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<AntiAliasingMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraOffsetFromTop");
			PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SprintFoVBoost");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_BobRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "BobRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamAcceleration");
			PlayerCamera.NativeFieldInfoPtr_SmoothLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLook");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSpeed");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeSmoother");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSmoother");
			PlayerCamera.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CameraContainer");
			PlayerCamera.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Camera");
			PlayerCamera.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "OverlayCamera");
			PlayerCamera.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Animator");
			PlayerCamera.NativeFieldInfoPtr_JoltClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "JoltClips");
			PlayerCamera.NativeFieldInfoPtr_URPAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "URPAssets");
			PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ViewAvatarCameraPosition");
			PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HeartbeatSoundController");
			PlayerCamera.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Flies");
			PlayerCamera.NativeFieldInfoPtr_MethRumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "MethRumble");
			PlayerCamera.NativeFieldInfoPtr_SchizoVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SchizoVoices");
			PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<canLook>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<transformOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<fovOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "blockNextStopTransformOverride");
			PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FreeCamEnabled>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ViewingAvatar>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CameraMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<MethVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CocaineVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FovJitter>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "globalVolume");
			PlayerCamera.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoF");
			PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<activeUIElements>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraShakeCoroutine");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalPos");
			PlayerCamera.NativeFieldInfoPtr_freeCamMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamMovement");
			PlayerCamera.NativeFieldInfoPtr_focusRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusRoutine");
			PlayerCamera.NativeFieldInfoPtr_focusMouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseX");
			PlayerCamera.NativeFieldInfoPtr_focusMouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseY");
			PlayerCamera.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "movementEvents");
			PlayerCamera.NativeFieldInfoPtr_freeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_mouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseX");
			PlayerCamera.NativeFieldInfoPtr_mouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseY");
			PlayerCamera.NativeFieldInfoPtr_seizureJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "seizureJitter");
			PlayerCamera.NativeFieldInfoPtr_schizoFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "schizoFoV");
			PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "timeUntilNextSchizoVoice");
			PlayerCamera.NativeFieldInfoPtr_gizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "gizmos");
			PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameralocalPos_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalRot_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCamera_Coroutine");
			PlayerCamera.NativeFieldInfoPtr_lookRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "lookRoutine");
			PlayerCamera.NativeFieldInfoPtr_DoFCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoFCoroutine");
			PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCameraFOV_Coroutine");
			PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673192);
			PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673193);
			PlayerCamera.NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673194);
			PlayerCamera.NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673195);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673196);
			PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673197);
			PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673198);
			PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673199);
			PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673200);
			PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673201);
			PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673202);
			PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673203);
			PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673204);
			PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673205);
			PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673206);
			PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673207);
			PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673208);
			PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673209);
			PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673210);
			PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673211);
			PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673212);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673213);
			PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673214);
			PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673215);
			PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673216);
			PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673217);
			PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673218);
			PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673219);
			PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673220);
			PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673221);
			PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673222);
			PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673223);
			PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673224);
			PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673225);
			PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673226);
			PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673227);
			PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673228);
			PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673229);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673230);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673231);
			PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673232);
			PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673233);
			PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673234);
			PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673235);
			PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673236);
			PlayerCamera.NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673237);
			PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673238);
			PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673239);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_True_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673240);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673241);
			PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673242);
			PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673243);
			PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673244);
			PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673245);
			PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673246);
			PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673247);
			PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673248);
			PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673249);
			PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673250);
			PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673251);
			PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673252);
			PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673253);
			PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673254);
			PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673255);
			PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673256);
			PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673257);
			PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673258);
			PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673259);
			PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673260);
			PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673261);
			PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673262);
			PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673263);
			PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673264);
			PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673265);
			PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673266);
			PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673267);
			PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673268);
			PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673269);
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x0017BAF4 File Offset: 0x00179CF4
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x0017BB24 File Offset: 0x00179D24
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172172, XrefRangeEnd = 172174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172174, XrefRangeEnd = 172176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x0017BB58 File Offset: 0x00179D58
		// (set) Token: 0x06004F27 RID: 20263 RVA: 0x0017BB94 File Offset: 0x00179D94
		public unsafe bool canLook
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(51)]
			[CachedScanResults(RefRangeStart = 49269, RefRangeEnd = 49320, XrefRangeStart = 49269, XrefRangeEnd = 49320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06004F28 RID: 20264 RVA: 0x0017BBD4 File Offset: 0x00179DD4
		public unsafe int activeUIElementCount
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 172177, RefRangeEnd = 172197, XrefRangeStart = 172176, XrefRangeEnd = 172177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06004F29 RID: 20265 RVA: 0x0017BC10 File Offset: 0x00179E10
		// (set) Token: 0x06004F2A RID: 20266 RVA: 0x0017BC4C File Offset: 0x00179E4C
		public unsafe bool transformOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x0017BC8C File Offset: 0x00179E8C
		// (set) Token: 0x06004F2C RID: 20268 RVA: 0x0017BCC8 File Offset: 0x00179EC8
		public unsafe bool fovOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004F2D RID: 20269 RVA: 0x0017BD08 File Offset: 0x00179F08
		// (set) Token: 0x06004F2E RID: 20270 RVA: 0x0017BD44 File Offset: 0x00179F44
		public unsafe bool FreeCamEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x0017BD84 File Offset: 0x00179F84
		// (set) Token: 0x06004F30 RID: 20272 RVA: 0x0017BDC0 File Offset: 0x00179FC0
		public unsafe bool ViewingAvatar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004F31 RID: 20273 RVA: 0x0017BE00 File Offset: 0x0017A000
		// (set) Token: 0x06004F32 RID: 20274 RVA: 0x0017BE3C File Offset: 0x0017A03C
		public unsafe PlayerCamera.ECameraMode CameraMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 49913, RefRangeEnd = 49917, XrefRangeStart = 49913, XrefRangeEnd = 49917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x0017BE7C File Offset: 0x0017A07C
		// (set) Token: 0x06004F34 RID: 20276 RVA: 0x0017BEB8 File Offset: 0x0017A0B8
		public unsafe bool MethVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x0017BEF8 File Offset: 0x0017A0F8
		// (set) Token: 0x06004F36 RID: 20278 RVA: 0x0017BF34 File Offset: 0x0017A134
		public unsafe bool CocaineVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x0017BF74 File Offset: 0x0017A174
		// (set) Token: 0x06004F38 RID: 20280 RVA: 0x0017BFB0 File Offset: 0x0017A1B0
		public unsafe float FovJitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004F39 RID: 20281 RVA: 0x0017BFF0 File Offset: 0x0017A1F0
		// (set) Token: 0x06004F3A RID: 20282 RVA: 0x0017C030 File Offset: 0x0017A230
		public unsafe List<string> activeUIElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x0017C074 File Offset: 0x0017A274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172197, XrefRangeEnd = 172246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x0017C0B0 File Offset: 0x0017A2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172246, XrefRangeEnd = 172256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x0017C0FC File Offset: 0x0017A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172256, XrefRangeEnd = 172304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x0017C138 File Offset: 0x0017A338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172304, XrefRangeEnd = 172323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x0017C16C File Offset: 0x0017A36C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172337, RefRangeEnd = 172340, XrefRangeStart = 172323, XrefRangeEnd = 172337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAntialiasingMode(Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x0017C1A0 File Offset: 0x0017A3A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172347, RefRangeEnd = 172349, XrefRangeStart = 172340, XrefRangeEnd = 172347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAASettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x0017C1D4 File Offset: 0x0017A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172349, XrefRangeEnd = 172426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x0017C210 File Offset: 0x0017A410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172426, XrefRangeEnd = 172431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Screenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x0017C244 File Offset: 0x0017A444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172431, XrefRangeEnd = 172480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x0017C280 File Offset: 0x0017A480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172480, XrefRangeEnd = 172482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x0017C2C4 File Offset: 0x0017A4C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 172490, RefRangeEnd = 172496, XrefRangeStart = 172482, XrefRangeEnd = 172490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetLocalY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x0017C300 File Offset: 0x0017A500
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 49913, RefRangeEnd = 49917, XrefRangeStart = 49913, XrefRangeEnd = 49917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x0017C340 File Offset: 0x0017A540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172574, RefRangeEnd = 172575, XrefRangeStart = 172496, XrefRangeEnd = 172574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x0017C374 File Offset: 0x0017A574
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 172585, RefRangeEnd = 172625, XrefRangeStart = 172575, XrefRangeEnd = 172585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x0017C3A8 File Offset: 0x0017A5A8
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 172635, RefRangeEnd = 172675, XrefRangeStart = 172625, XrefRangeEnd = 172635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x0017C3DC File Offset: 0x0017A5DC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 172684, RefRangeEnd = 172714, XrefRangeStart = 172675, XrefRangeEnd = 172684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x0017C460 File Offset: 0x0017A660
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 172748, RefRangeEnd = 172752, XrefRangeStart = 172714, XrefRangeEnd = 172748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x0017C4D4 File Offset: 0x0017A6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172752, XrefRangeEnd = 172759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x0017C508 File Offset: 0x0017A708
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 172799, RefRangeEnd = 172807, XrefRangeStart = 172759, XrefRangeEnd = 172799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAngleDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x0017C5B4 File Offset: 0x0017A7B4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 172818, RefRangeEnd = 172831, XrefRangeStart = 172807, XrefRangeEnd = 172818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x0017C638 File Offset: 0x0017A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172831, XrefRangeEnd = 172840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x0017C6AC File Offset: 0x0017A8AC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 172861, RefRangeEnd = 172915, XrefRangeStart = 172840, XrefRangeEnd = 172861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepParented;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x0017C714 File Offset: 0x0017A914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172915, XrefRangeEnd = 172920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endRot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToRestingPosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x0017C7A8 File Offset: 0x0017A9A8
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 172942, RefRangeEnd = 172973, XrefRangeStart = 172920, XrefRangeEnd = 172942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableCameraLook;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToOriginalRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x0017C804 File Offset: 0x0017AA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172973, XrefRangeEnd = 172986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 point, float duration = 0.25f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x0017C850 File Offset: 0x0017AA50
		[CallerCount(0)]
		public unsafe void SetCanLook_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_True_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x0017C884 File Offset: 0x0017AA84
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 49269, RefRangeEnd = 49320, XrefRangeStart = 49269, XrefRangeEnd = 49320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanLook(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x0017C8C4 File Offset: 0x0017AAC4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 172994, RefRangeEnd = 173016, XrefRangeStart = 172986, XrefRangeEnd = 172994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoFActive(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x0017C910 File Offset: 0x0017AB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173016, XrefRangeEnd = 173021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpDoF(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x0017C96C File Offset: 0x0017AB6C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 173034, RefRangeEnd = 173078, XrefRangeStart = 173021, XrefRangeEnd = 173034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideFOV(float fov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x0017C9B8 File Offset: 0x0017ABB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173078, XrefRangeEnd = 173083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endFov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x0017CA14 File Offset: 0x0017AC14
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 173095, RefRangeEnd = 173121, XrefRangeStart = 173083, XrefRangeEnd = 173095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFOVOverride(float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x0017CA54 File Offset: 0x0017AC54
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 173127, RefRangeEnd = 173190, XrefRangeStart = 173121, XrefRangeEnd = 173127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x0017CA98 File Offset: 0x0017AC98
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 173196, RefRangeEnd = 173262, XrefRangeStart = 173190, XrefRangeEnd = 173196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x0017CADC File Offset: 0x0017ACDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173280, RefRangeEnd = 173282, XrefRangeStart = 173262, XrefRangeEnd = 173280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x0017CB2C File Offset: 0x0017AD2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173310, RefRangeEnd = 173311, XrefRangeStart = 173282, XrefRangeEnd = 173310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x0017CB70 File Offset: 0x0017AD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173344, RefRangeEnd = 173345, XrefRangeStart = 173311, XrefRangeEnd = 173344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0017CBA4 File Offset: 0x0017ADA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173393, RefRangeEnd = 173394, XrefRangeStart = 173345, XrefRangeEnd = 173393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x0017CBD8 File Offset: 0x0017ADD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173414, RefRangeEnd = 173416, XrefRangeStart = 173394, XrefRangeEnd = 173414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopViewingAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x0017CC0C File Offset: 0x0017AE0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173419, RefRangeEnd = 173422, XrefRangeStart = 173416, XrefRangeEnd = 173419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoltCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x0017CC40 File Offset: 0x0017AE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173422, XrefRangeEnd = 173446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x0017CC8C File Offset: 0x0017AE8C
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x0017CCD8 File Offset: 0x0017AED8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173450, RefRangeEnd = 173453, XrefRangeStart = 173446, XrefRangeEnd = 173450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x0017CD0C File Offset: 0x0017AF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173468, RefRangeEnd = 173469, XrefRangeStart = 173453, XrefRangeEnd = 173468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusCameraOnTarget(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x0017CD50 File Offset: 0x0017AF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173470, RefRangeEnd = 173471, XrefRangeStart = 173469, XrefRangeEnd = 173470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x0017CD84 File Offset: 0x0017AF84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173489, RefRangeEnd = 173492, XrefRangeStart = 173471, XrefRangeEnd = 173489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decreaseOverTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x0017CDE0 File Offset: 0x0017AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173492, XrefRangeEnd = 173497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCameraShake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x0017CE14 File Offset: 0x0017B014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173514, RefRangeEnd = 173515, XrefRangeStart = 173497, XrefRangeEnd = 173514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x0017CE48 File Offset: 0x0017B048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173538, RefRangeEnd = 173541, XrefRangeStart = 173515, XrefRangeEnd = 173538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFreeCam(bool enable, bool reenableLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableLook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x0017CE94 File Offset: 0x0017B094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173590, RefRangeEnd = 173591, XrefRangeStart = 173541, XrefRangeEnd = 173590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x0017CEC8 File Offset: 0x0017B0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173615, RefRangeEnd = 173616, XrefRangeStart = 173591, XrefRangeEnd = 173615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFreeCamInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x0017CEFC File Offset: 0x0017B0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173627, RefRangeEnd = 173628, XrefRangeStart = 173616, XrefRangeEnd = 173627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x0017CF30 File Offset: 0x0017B130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173628, XrefRangeEnd = 173662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x0017CF6C File Offset: 0x0017B16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173662, XrefRangeEnd = 173680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayerSpawned_b__92_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x0017CFA0 File Offset: 0x0017B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173680, XrefRangeEnd = 173684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x00025AAF File Offset: 0x00023CAF
		public PlayerCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x0017CFD4 File Offset: 0x0017B1D4
		// (set) Token: 0x06004F74 RID: 20340 RVA: 0x00025AB8 File Offset: 0x00023CB8
		public unsafe static float CAMERA_SHAKE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x0017CFF0 File Offset: 0x0017B1F0
		// (set) Token: 0x06004F76 RID: 20342 RVA: 0x00025AC6 File Offset: 0x00023CC6
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode _AntiAliasingMode_k__BackingField
		{
			get
			{
				Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x0017D00C File Offset: 0x0017B20C
		// (set) Token: 0x06004F78 RID: 20344 RVA: 0x00025AD4 File Offset: 0x00023CD4
		public unsafe float cameraOffsetFromTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop)) = value;
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x0017D034 File Offset: 0x0017B234
		// (set) Token: 0x06004F7A RID: 20346 RVA: 0x00025AEF File Offset: 0x00023CEF
		public unsafe float SprintFoVBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost)) = value;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06004F7B RID: 20347 RVA: 0x0017D05C File Offset: 0x0017B25C
		// (set) Token: 0x06004F7C RID: 20348 RVA: 0x00025B0A File Offset: 0x00023D0A
		public unsafe float FoVChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate)) = value;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x0017D084 File Offset: 0x0017B284
		// (set) Token: 0x06004F7E RID: 20350 RVA: 0x00025B25 File Offset: 0x00023D25
		public unsafe float HorizontalCameraBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob)) = value;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06004F7F RID: 20351 RVA: 0x0017D0AC File Offset: 0x0017B2AC
		// (set) Token: 0x06004F80 RID: 20352 RVA: 0x00025B40 File Offset: 0x00023D40
		public unsafe float VerticalCameraBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob)) = value;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x0017D0D4 File Offset: 0x0017B2D4
		// (set) Token: 0x06004F82 RID: 20354 RVA: 0x00025B5B File Offset: 0x00023D5B
		public unsafe float BobRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate)) = value;
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06004F83 RID: 20355 RVA: 0x0017D0FC File Offset: 0x0017B2FC
		// (set) Token: 0x06004F84 RID: 20356 RVA: 0x00025B76 File Offset: 0x00023D76
		public unsafe AnimationCurve HorizontalBobCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x0017D12C File Offset: 0x0017B32C
		// (set) Token: 0x06004F86 RID: 20358 RVA: 0x00025B95 File Offset: 0x00023D95
		public unsafe AnimationCurve VerticalBobCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x0017D15C File Offset: 0x0017B35C
		// (set) Token: 0x06004F88 RID: 20360 RVA: 0x00025BB4 File Offset: 0x00023DB4
		public unsafe float FreeCamSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed)) = value;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06004F89 RID: 20361 RVA: 0x0017D184 File Offset: 0x0017B384
		// (set) Token: 0x06004F8A RID: 20362 RVA: 0x00025BCF File Offset: 0x00023DCF
		public unsafe float FreeCamAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration)) = value;
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x0017D1AC File Offset: 0x0017B3AC
		// (set) Token: 0x06004F8C RID: 20364 RVA: 0x00025BEA File Offset: 0x00023DEA
		public unsafe bool SmoothLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook)) = value;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x0017D1D4 File Offset: 0x0017B3D4
		// (set) Token: 0x06004F8E RID: 20366 RVA: 0x00025C05 File Offset: 0x00023E05
		public unsafe float SmoothLookSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed)) = value;
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x0017D1FC File Offset: 0x0017B3FC
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x00025C20 File Offset: 0x00023E20
		public unsafe FloatSmoother FoVChangeSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x0017D22C File Offset: 0x0017B42C
		// (set) Token: 0x06004F92 RID: 20370 RVA: 0x00025C3F File Offset: 0x00023E3F
		public unsafe FloatSmoother SmoothLookSmoother
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x0017D25C File Offset: 0x0017B45C
		// (set) Token: 0x06004F94 RID: 20372 RVA: 0x00025C5E File Offset: 0x00023E5E
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x0017D28C File Offset: 0x0017B48C
		// (set) Token: 0x06004F96 RID: 20374 RVA: 0x00025C7D File Offset: 0x00023E7D
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06004F97 RID: 20375 RVA: 0x0017D2BC File Offset: 0x0017B4BC
		// (set) Token: 0x06004F98 RID: 20376 RVA: 0x00025C9C File Offset: 0x00023E9C
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06004F99 RID: 20377 RVA: 0x0017D2EC File Offset: 0x0017B4EC
		// (set) Token: 0x06004F9A RID: 20378 RVA: 0x00025CBB File Offset: 0x00023EBB
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x0017D31C File Offset: 0x0017B51C
		// (set) Token: 0x06004F9C RID: 20380 RVA: 0x00025CDA File Offset: 0x00023EDA
		public unsafe Il2CppReferenceArray<AnimationClip> JoltClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x0017D34C File Offset: 0x0017B54C
		// (set) Token: 0x06004F9E RID: 20382 RVA: 0x00025CF9 File Offset: 0x00023EF9
		public unsafe Il2CppReferenceArray<UniversalRenderPipelineAsset> URPAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UniversalRenderPipelineAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06004F9F RID: 20383 RVA: 0x0017D37C File Offset: 0x0017B57C
		// (set) Token: 0x06004FA0 RID: 20384 RVA: 0x00025D18 File Offset: 0x00023F18
		public unsafe Transform ViewAvatarCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x0017D3AC File Offset: 0x0017B5AC
		// (set) Token: 0x06004FA2 RID: 20386 RVA: 0x00025D37 File Offset: 0x00023F37
		public unsafe HeartbeatSoundController HeartbeatSoundController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeartbeatSoundController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x0017D3DC File Offset: 0x0017B5DC
		// (set) Token: 0x06004FA4 RID: 20388 RVA: 0x00025D56 File Offset: 0x00023F56
		public unsafe ParticleSystem Flies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x0017D40C File Offset: 0x0017B60C
		// (set) Token: 0x06004FA6 RID: 20390 RVA: 0x00025D75 File Offset: 0x00023F75
		public unsafe AudioSourceController MethRumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06004FA7 RID: 20391 RVA: 0x0017D43C File Offset: 0x0017B63C
		// (set) Token: 0x06004FA8 RID: 20392 RVA: 0x00025D94 File Offset: 0x00023F94
		public unsafe RandomizedAudioSourceController SchizoVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizedAudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x0017D46C File Offset: 0x0017B66C
		// (set) Token: 0x06004FAA RID: 20394 RVA: 0x00025DB3 File Offset: 0x00023FB3
		public unsafe bool _canLook_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField)) = value;
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x0017D494 File Offset: 0x0017B694
		// (set) Token: 0x06004FAC RID: 20396 RVA: 0x00025DCE File Offset: 0x00023FCE
		public unsafe bool _transformOverriden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x0017D4BC File Offset: 0x0017B6BC
		// (set) Token: 0x06004FAE RID: 20398 RVA: 0x00025DE9 File Offset: 0x00023FE9
		public unsafe bool _fovOverriden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x0017D4E4 File Offset: 0x0017B6E4
		// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x00025E04 File Offset: 0x00024004
		public unsafe bool blockNextStopTransformOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride)) = value;
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x0017D50C File Offset: 0x0017B70C
		// (set) Token: 0x06004FB2 RID: 20402 RVA: 0x00025E1F File Offset: 0x0002401F
		public unsafe bool _FreeCamEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x0017D534 File Offset: 0x0017B734
		// (set) Token: 0x06004FB4 RID: 20404 RVA: 0x00025E3A File Offset: 0x0002403A
		public unsafe bool _ViewingAvatar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x0017D55C File Offset: 0x0017B75C
		// (set) Token: 0x06004FB6 RID: 20406 RVA: 0x00025E55 File Offset: 0x00024055
		public unsafe PlayerCamera.ECameraMode _CameraMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x0017D584 File Offset: 0x0017B784
		// (set) Token: 0x06004FB8 RID: 20408 RVA: 0x00025E70 File Offset: 0x00024070
		public unsafe bool _MethVisuals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x0017D5AC File Offset: 0x0017B7AC
		// (set) Token: 0x06004FBA RID: 20410 RVA: 0x00025E8B File Offset: 0x0002408B
		public unsafe bool _CocaineVisuals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x0017D5D4 File Offset: 0x0017B7D4
		// (set) Token: 0x06004FBC RID: 20412 RVA: 0x00025EA6 File Offset: 0x000240A6
		public unsafe float _FovJitter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField)) = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x0017D5FC File Offset: 0x0017B7FC
		// (set) Token: 0x06004FBE RID: 20414 RVA: 0x00025EC1 File Offset: 0x000240C1
		public unsafe Volume globalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x0017D62C File Offset: 0x0017B82C
		// (set) Token: 0x06004FC0 RID: 20416 RVA: 0x00025EE0 File Offset: 0x000240E0
		public unsafe DepthOfField DoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x0017D65C File Offset: 0x0017B85C
		// (set) Token: 0x06004FC2 RID: 20418 RVA: 0x00025EFF File Offset: 0x000240FF
		public unsafe List<string> _activeUIElements_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x0017D68C File Offset: 0x0017B88C
		// (set) Token: 0x06004FC4 RID: 20420 RVA: 0x00025F1E File Offset: 0x0002411E
		public unsafe Coroutine cameraShakeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x0017D6BC File Offset: 0x0017B8BC
		// (set) Token: 0x06004FC6 RID: 20422 RVA: 0x00025F3D File Offset: 0x0002413D
		public unsafe Vector3 cameraLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos)) = value;
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x0017D6E4 File Offset: 0x0017B8E4
		// (set) Token: 0x06004FC8 RID: 20424 RVA: 0x00025F58 File Offset: 0x00024158
		public unsafe Vector3 freeCamMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement)) = value;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x0017D70C File Offset: 0x0017B90C
		// (set) Token: 0x06004FCA RID: 20426 RVA: 0x00025F73 File Offset: 0x00024173
		public unsafe Coroutine focusRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x0017D73C File Offset: 0x0017B93C
		// (set) Token: 0x06004FCC RID: 20428 RVA: 0x00025F92 File Offset: 0x00024192
		public unsafe float focusMouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX)) = value;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x0017D764 File Offset: 0x0017B964
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x00025FAD File Offset: 0x000241AD
		public unsafe float focusMouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY)) = value;
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x0017D78C File Offset: 0x0017B98C
		// (set) Token: 0x06004FD0 RID: 20432 RVA: 0x00025FC8 File Offset: 0x000241C8
		public unsafe Dictionary<int, PlayerMovement.MovementEvent> movementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PlayerMovement.MovementEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x0017D7BC File Offset: 0x0017B9BC
		// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x00025FE7 File Offset: 0x000241E7
		public unsafe float freeCamSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed)) = value;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x0017D7E4 File Offset: 0x0017B9E4
		// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x00026002 File Offset: 0x00024202
		public unsafe float mouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX)) = value;
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x0017D80C File Offset: 0x0017BA0C
		// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x0002601D File Offset: 0x0002421D
		public unsafe float mouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY)) = value;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x0017D834 File Offset: 0x0017BA34
		// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x00026038 File Offset: 0x00024238
		public unsafe Vector2 seizureJitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter)) = value;
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x0017D85C File Offset: 0x0017BA5C
		// (set) Token: 0x06004FDA RID: 20442 RVA: 0x00026053 File Offset: 0x00024253
		public unsafe float schizoFoV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV)) = value;
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x0017D884 File Offset: 0x0017BA84
		// (set) Token: 0x06004FDC RID: 20444 RVA: 0x0002606E File Offset: 0x0002426E
		public unsafe float timeUntilNextSchizoVoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice)) = value;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x0017D8AC File Offset: 0x0017BAAC
		// (set) Token: 0x06004FDE RID: 20446 RVA: 0x00026089 File Offset: 0x00024289
		public unsafe List<Vector3> gizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x0017D8DC File Offset: 0x0017BADC
		// (set) Token: 0x06004FE0 RID: 20448 RVA: 0x000260A8 File Offset: 0x000242A8
		public unsafe Vector3 cameralocalPos_PriorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride)) = value;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x0017D904 File Offset: 0x0017BB04
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x000260C3 File Offset: 0x000242C3
		public unsafe Quaternion cameraLocalRot_PriorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride)) = value;
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x0017D92C File Offset: 0x0017BB2C
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x000260DE File Offset: 0x000242DE
		public unsafe Coroutine ILerpCamera_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x0017D95C File Offset: 0x0017BB5C
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x000260FD File Offset: 0x000242FD
		public unsafe Coroutine lookRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x0017D98C File Offset: 0x0017BB8C
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x0002611C File Offset: 0x0002431C
		public unsafe Coroutine DoFCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x0017D9BC File Offset: 0x0017BBBC
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x0002613B File Offset: 0x0002433B
		public unsafe Coroutine ILerpCameraFOV_Coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035A4 RID: 13732
		private static readonly IntPtr NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER;

		// Token: 0x040035A5 RID: 13733
		private static readonly IntPtr NativeFieldInfoPtr__AntiAliasingMode_k__BackingField;

		// Token: 0x040035A6 RID: 13734
		private static readonly IntPtr NativeFieldInfoPtr_cameraOffsetFromTop;

		// Token: 0x040035A7 RID: 13735
		private static readonly IntPtr NativeFieldInfoPtr_SprintFoVBoost;

		// Token: 0x040035A8 RID: 13736
		private static readonly IntPtr NativeFieldInfoPtr_FoVChangeRate;

		// Token: 0x040035A9 RID: 13737
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalCameraBob;

		// Token: 0x040035AA RID: 13738
		private static readonly IntPtr NativeFieldInfoPtr_VerticalCameraBob;

		// Token: 0x040035AB RID: 13739
		private static readonly IntPtr NativeFieldInfoPtr_BobRate;

		// Token: 0x040035AC RID: 13740
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalBobCurve;

		// Token: 0x040035AD RID: 13741
		private static readonly IntPtr NativeFieldInfoPtr_VerticalBobCurve;

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeFieldInfoPtr_FreeCamSpeed;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeFieldInfoPtr_FreeCamAcceleration;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLook;

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLookSpeed;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeFieldInfoPtr_FoVChangeSmoother;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeFieldInfoPtr_SmoothLookSmoother;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040035B8 RID: 13752
		private static readonly IntPtr NativeFieldInfoPtr_JoltClips;

		// Token: 0x040035B9 RID: 13753
		private static readonly IntPtr NativeFieldInfoPtr_URPAssets;

		// Token: 0x040035BA RID: 13754
		private static readonly IntPtr NativeFieldInfoPtr_ViewAvatarCameraPosition;

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeFieldInfoPtr_HeartbeatSoundController;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeFieldInfoPtr_MethRumble;

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeFieldInfoPtr_SchizoVoices;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeFieldInfoPtr__canLook_k__BackingField;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeFieldInfoPtr__transformOverriden_k__BackingField;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeFieldInfoPtr__fovOverriden_k__BackingField;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeFieldInfoPtr_blockNextStopTransformOverride;

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeFieldInfoPtr__FreeCamEnabled_k__BackingField;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeFieldInfoPtr__ViewingAvatar_k__BackingField;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeFieldInfoPtr__CameraMode_k__BackingField;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeFieldInfoPtr__MethVisuals_k__BackingField;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeFieldInfoPtr__CocaineVisuals_k__BackingField;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeFieldInfoPtr__FovJitter_k__BackingField;

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeFieldInfoPtr_globalVolume;

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeFieldInfoPtr__activeUIElements_k__BackingField;

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeFieldInfoPtr_cameraShakeCoroutine;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocalPos;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeFieldInfoPtr_freeCamMovement;

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeFieldInfoPtr_focusRoutine;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeFieldInfoPtr_focusMouseX;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeFieldInfoPtr_focusMouseY;

		// Token: 0x040035D2 RID: 13778
		private static readonly IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x040035D3 RID: 13779
		private static readonly IntPtr NativeFieldInfoPtr_freeCamSpeed;

		// Token: 0x040035D4 RID: 13780
		private static readonly IntPtr NativeFieldInfoPtr_mouseX;

		// Token: 0x040035D5 RID: 13781
		private static readonly IntPtr NativeFieldInfoPtr_mouseY;

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeFieldInfoPtr_seizureJitter;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeFieldInfoPtr_schizoFoV;

		// Token: 0x040035D8 RID: 13784
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextSchizoVoice;

		// Token: 0x040035D9 RID: 13785
		private static readonly IntPtr NativeFieldInfoPtr_gizmos;

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeFieldInfoPtr_cameralocalPos_PriorOverride;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocalRot_PriorOverride;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeFieldInfoPtr_ILerpCamera_Coroutine;

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeFieldInfoPtr_lookRoutine;

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeFieldInfoPtr_DoFCoroutine;

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeFieldInfoPtr_ILerpCameraFOV_Coroutine;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0;

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0;

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0;

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0;

		// Token: 0x040035E7 RID: 13799
		private static readonly IntPtr NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0;

		// Token: 0x040035E8 RID: 13800
		private static readonly IntPtr NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0;

		// Token: 0x040035E9 RID: 13801
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0;

		// Token: 0x040035EA RID: 13802
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040035EB RID: 13803
		private static readonly IntPtr NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0;

		// Token: 0x040035EC RID: 13804
		private static readonly IntPtr NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0;

		// Token: 0x040035ED RID: 13805
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0;

		// Token: 0x040035EE RID: 13806
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0;

		// Token: 0x040035EF RID: 13807
		private static readonly IntPtr NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0;

		// Token: 0x040035F0 RID: 13808
		private static readonly IntPtr NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0;

		// Token: 0x040035F1 RID: 13809
		private static readonly IntPtr NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0;

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0;

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0;

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0;

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0;

		// Token: 0x040035F7 RID: 13815
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040035F8 RID: 13816
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x040035F9 RID: 13817
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040035FA RID: 13818
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x040035FB RID: 13819
		private static readonly IntPtr NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0;

		// Token: 0x040035FC RID: 13820
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAASettings_Public_Void_0;

		// Token: 0x040035FD RID: 13821
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040035FE RID: 13822
		private static readonly IntPtr NativeMethodInfoPtr_Screenshot_Private_Void_0;

		// Token: 0x040035FF RID: 13823
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04003600 RID: 13824
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04003601 RID: 13825
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0;

		// Token: 0x04003602 RID: 13826
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0;

		// Token: 0x04003603 RID: 13827
		private static readonly IntPtr NativeMethodInfoPtr_RotateCamera_Private_Void_0;

		// Token: 0x04003604 RID: 13828
		private static readonly IntPtr NativeMethodInfoPtr_LockMouse_Public_Void_0;

		// Token: 0x04003605 RID: 13829
		private static readonly IntPtr NativeMethodInfoPtr_FreeMouse_Public_Void_0;

		// Token: 0x04003606 RID: 13830
		private static readonly IntPtr NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x04003607 RID: 13831
		private static readonly IntPtr NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0;

		// Token: 0x04003608 RID: 13832
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04003609 RID: 13833
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0;

		// Token: 0x0400360A RID: 13834
		private static readonly IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x0400360B RID: 13835
		private static readonly IntPtr NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0;

		// Token: 0x0400360C RID: 13836
		private static readonly IntPtr NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x0400360D RID: 13837
		private static readonly IntPtr NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400360E RID: 13838
		private static readonly IntPtr NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400360F RID: 13839
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0;

		// Token: 0x04003610 RID: 13840
		private static readonly IntPtr NativeMethodInfoPtr_SetCanLook_True_Private_Void_0;

		// Token: 0x04003611 RID: 13841
		private static readonly IntPtr NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0;

		// Token: 0x04003612 RID: 13842
		private static readonly IntPtr NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0;

		// Token: 0x04003613 RID: 13843
		private static readonly IntPtr NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04003614 RID: 13844
		private static readonly IntPtr NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0;

		// Token: 0x04003615 RID: 13845
		private static readonly IntPtr NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0;

		// Token: 0x04003616 RID: 13846
		private static readonly IntPtr NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0;

		// Token: 0x04003617 RID: 13847
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0;

		// Token: 0x04003618 RID: 13848
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0;

		// Token: 0x04003619 RID: 13849
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x0400361A RID: 13850
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x0400361B RID: 13851
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x0400361C RID: 13852
		private static readonly IntPtr NativeMethodInfoPtr_ViewAvatar_Private_Void_0;

		// Token: 0x0400361D RID: 13853
		private static readonly IntPtr NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0;

		// Token: 0x0400361E RID: 13854
		private static readonly IntPtr NativeMethodInfoPtr_JoltCamera_Public_Void_0;

		// Token: 0x0400361F RID: 13855
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x04003620 RID: 13856
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x04003621 RID: 13857
		private static readonly IntPtr NativeMethodInfoPtr_ResetRotation_Public_Void_0;

		// Token: 0x04003622 RID: 13858
		private static readonly IntPtr NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0;

		// Token: 0x04003623 RID: 13859
		private static readonly IntPtr NativeMethodInfoPtr_StopFocus_Public_Void_0;

		// Token: 0x04003624 RID: 13860
		private static readonly IntPtr NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0;

		// Token: 0x04003625 RID: 13861
		private static readonly IntPtr NativeMethodInfoPtr_StopCameraShake_Public_Void_0;

		// Token: 0x04003626 RID: 13862
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0;

		// Token: 0x04003627 RID: 13863
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0;

		// Token: 0x04003628 RID: 13864
		private static readonly IntPtr NativeMethodInfoPtr_RotateFreeCam_Private_Void_0;

		// Token: 0x04003629 RID: 13865
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0;

		// Token: 0x0400362A RID: 13866
		private static readonly IntPtr NativeMethodInfoPtr_MoveFreeCam_Private_Void_0;

		// Token: 0x0400362B RID: 13867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400362C RID: 13868
		private static readonly IntPtr NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0;

		// Token: 0x0400362D RID: 13869
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x02000995 RID: 2453
		[OriginalName("Assembly-CSharp.dll", "", "ECameraMode")]
		public enum ECameraMode
		{
			// Token: 0x0400890C RID: 35084
			Default,
			// Token: 0x0400890D RID: 35085
			Vehicle,
			// Token: 0x0400890E RID: 35086
			Skateboard
		}

		// Token: 0x02000996 RID: 2454
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<<Screenshot>g__Routine|96_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CAA1 RID: 51873 RVA: 0x0030FBC0 File Offset: 0x0030DDC0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<<Screenshot>g__Routine|96_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673270);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673271);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673272);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673273);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673274);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673275);
			}

			// Token: 0x0600CAA2 RID: 51874 RVA: 0x0030FC8C File Offset: 0x0030DE8C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAA3 RID: 51875 RVA: 0x0030FCD4 File Offset: 0x0030DED4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAA4 RID: 51876 RVA: 0x0030FD08 File Offset: 0x0030DF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171951, XrefRangeEnd = 171959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F1C RID: 16156
			// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x0030FD44 File Offset: 0x0030DF44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAA6 RID: 51878 RVA: 0x0030FD84 File Offset: 0x0030DF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171959, XrefRangeEnd = 171964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F1D RID: 16157
			// (get) Token: 0x0600CAA7 RID: 51879 RVA: 0x0030FDB8 File Offset: 0x0030DFB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAA8 RID: 51880 RVA: 0x000627FA File Offset: 0x000609FA
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F1A RID: 16154
			// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x0030FDF8 File Offset: 0x0030DFF8
			// (set) Token: 0x0600CAAA RID: 51882 RVA: 0x00062803 File Offset: 0x00060A03
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F1B RID: 16155
			// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x0030FE20 File Offset: 0x0030E020
			// (set) Token: 0x0600CAAC RID: 51884 RVA: 0x0006281E File Offset: 0x00060A1E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400890F RID: 35087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008910 RID: 35088
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008911 RID: 35089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008912 RID: 35090
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008913 RID: 35091
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008914 RID: 35092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008915 RID: 35093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008916 RID: 35094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000997 RID: 2455
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass118_0")]
		public sealed class __c__DisplayClass118_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CAAD RID: 51885 RVA: 0x0030FE50 File Offset: 0x0030E050
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass118_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass118_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "point");
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, 100673276);
				PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, 100673277);
			}

			// Token: 0x0600CAAE RID: 51886 RVA: 0x0030FEE0 File Offset: 0x0030E0E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass118_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAAF RID: 51887 RVA: 0x0030FF1C File Offset: 0x0030E11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172014, XrefRangeEnd = 172019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CAB0 RID: 51888 RVA: 0x0006283D File Offset: 0x00060A3D
			public __c__DisplayClass118_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F1E RID: 16158
			// (get) Token: 0x0600CAB1 RID: 51889 RVA: 0x0030FF5C File Offset: 0x0030E15C
			// (set) Token: 0x0600CAB2 RID: 51890 RVA: 0x00062846 File Offset: 0x00060A46
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17003F1F RID: 16159
			// (get) Token: 0x0600CAB3 RID: 51891 RVA: 0x0030FF84 File Offset: 0x0030E184
			// (set) Token: 0x0600CAB4 RID: 51892 RVA: 0x00062861 File Offset: 0x00060A61
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F20 RID: 16160
			// (get) Token: 0x0600CAB5 RID: 51893 RVA: 0x0030FFB4 File Offset: 0x0030E1B4
			// (set) Token: 0x0600CAB6 RID: 51894 RVA: 0x00062880 File Offset: 0x00060A80
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x04008917 RID: 35095
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008918 RID: 35096
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008919 RID: 35097
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400891A RID: 35098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400891B RID: 35099
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C44 RID: 3140
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass118_0+<<LookAt>g__Look|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E261 RID: 57953 RVA: 0x00352B18 File Offset: 0x00350D18
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "<<LookAt>g__Look|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerEndRot>5__2");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraRotation>5__3");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerStartRot>5__4");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraStartRot>5__5");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<i>5__6");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673278);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673279);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673280);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673281);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673282);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673283);
				}

				// Token: 0x0600E262 RID: 57954 RVA: 0x00352C5C File Offset: 0x00350E5C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E263 RID: 57955 RVA: 0x00352CA4 File Offset: 0x00350EA4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E264 RID: 57956 RVA: 0x00352CD8 File Offset: 0x00350ED8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171964, XrefRangeEnd = 172009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700463B RID: 17979
				// (get) Token: 0x0600E265 RID: 57957 RVA: 0x00352D14 File Offset: 0x00350F14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E266 RID: 57958 RVA: 0x00352D54 File Offset: 0x00350F54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172009, XrefRangeEnd = 172014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700463C RID: 17980
				// (get) Token: 0x0600E267 RID: 57959 RVA: 0x00352D88 File Offset: 0x00350F88
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E268 RID: 57960 RVA: 0x0006E5DB File Offset: 0x0006C7DB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004633 RID: 17971
				// (get) Token: 0x0600E269 RID: 57961 RVA: 0x00352DC8 File Offset: 0x00350FC8
				// (set) Token: 0x0600E26A RID: 57962 RVA: 0x0006E5E4 File Offset: 0x0006C7E4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004634 RID: 17972
				// (get) Token: 0x0600E26B RID: 57963 RVA: 0x00352DF0 File Offset: 0x00350FF0
				// (set) Token: 0x0600E26C RID: 57964 RVA: 0x0006E5FF File Offset: 0x0006C7FF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004635 RID: 17973
				// (get) Token: 0x0600E26D RID: 57965 RVA: 0x00352E20 File Offset: 0x00351020
				// (set) Token: 0x0600E26E RID: 57966 RVA: 0x0006E61E File Offset: 0x0006C81E
				public unsafe PlayerCamera.__c__DisplayClass118_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass118_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004636 RID: 17974
				// (get) Token: 0x0600E26F RID: 57967 RVA: 0x00352E50 File Offset: 0x00351050
				// (set) Token: 0x0600E270 RID: 57968 RVA: 0x0006E63D File Offset: 0x0006C83D
				public unsafe Quaternion _playerEndRot_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2)) = value;
					}
				}

				// Token: 0x17004637 RID: 17975
				// (get) Token: 0x0600E271 RID: 57969 RVA: 0x00352E78 File Offset: 0x00351078
				// (set) Token: 0x0600E272 RID: 57970 RVA: 0x0006E658 File Offset: 0x0006C858
				public unsafe Quaternion _cameraRotation_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3)) = value;
					}
				}

				// Token: 0x17004638 RID: 17976
				// (get) Token: 0x0600E273 RID: 57971 RVA: 0x00352EA0 File Offset: 0x003510A0
				// (set) Token: 0x0600E274 RID: 57972 RVA: 0x0006E673 File Offset: 0x0006C873
				public unsafe Quaternion _playerStartRot_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4)) = value;
					}
				}

				// Token: 0x17004639 RID: 17977
				// (get) Token: 0x0600E275 RID: 57973 RVA: 0x00352EC8 File Offset: 0x003510C8
				// (set) Token: 0x0600E276 RID: 57974 RVA: 0x0006E68E File Offset: 0x0006C88E
				public unsafe Quaternion _cameraStartRot_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5)) = value;
					}
				}

				// Token: 0x1700463A RID: 17978
				// (get) Token: 0x0600E277 RID: 57975 RVA: 0x00352EF0 File Offset: 0x003510F0
				// (set) Token: 0x0600E278 RID: 57976 RVA: 0x0006E6A9 File Offset: 0x0006C8A9
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009788 RID: 38792
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009789 RID: 38793
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400978A RID: 38794
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400978B RID: 38795
				private static readonly IntPtr NativeFieldInfoPtr__playerEndRot_5__2;

				// Token: 0x0400978C RID: 38796
				private static readonly IntPtr NativeFieldInfoPtr__cameraRotation_5__3;

				// Token: 0x0400978D RID: 38797
				private static readonly IntPtr NativeFieldInfoPtr__playerStartRot_5__4;

				// Token: 0x0400978E RID: 38798
				private static readonly IntPtr NativeFieldInfoPtr__cameraStartRot_5__5;

				// Token: 0x0400978F RID: 38799
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x04009790 RID: 38800
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009791 RID: 38801
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009792 RID: 38802
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009793 RID: 38803
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009794 RID: 38804
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009795 RID: 38805
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000998 RID: 2456
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CAB7 RID: 51895 RVA: 0x0030FFDC File Offset: 0x0030E1DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "target");
				PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, 100673284);
				PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, 100673285);
			}

			// Token: 0x0600CAB8 RID: 51896 RVA: 0x00310058 File Offset: 0x0030E258
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAB9 RID: 51897 RVA: 0x00310094 File Offset: 0x0030E294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172074, XrefRangeEnd = 172079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CABA RID: 51898 RVA: 0x0006289B File Offset: 0x00060A9B
			public __c__DisplayClass139_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F21 RID: 16161
			// (get) Token: 0x0600CABB RID: 51899 RVA: 0x003100D4 File Offset: 0x0030E2D4
			// (set) Token: 0x0600CABC RID: 51900 RVA: 0x000628A4 File Offset: 0x00060AA4
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F22 RID: 16162
			// (get) Token: 0x0600CABD RID: 51901 RVA: 0x00310104 File Offset: 0x0030E304
			// (set) Token: 0x0600CABE RID: 51902 RVA: 0x000628C3 File Offset: 0x00060AC3
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400891C RID: 35100
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400891D RID: 35101
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400891E RID: 35102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400891F RID: 35103
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C45 RID: 3141
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass139_0+<<FocusCameraOnTarget>g__FocusRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E279 RID: 57977 RVA: 0x00352F18 File Offset: 0x00351118
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "<<FocusCameraOnTarget>g__FocusRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<duration>5__2");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673286);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673287);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673288);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673289);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673290);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673291);
				}

				// Token: 0x0600E27A RID: 57978 RVA: 0x0035300C File Offset: 0x0035120C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E27B RID: 57979 RVA: 0x00353054 File Offset: 0x00351254
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E27C RID: 57980 RVA: 0x00353088 File Offset: 0x00351288
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172019, XrefRangeEnd = 172069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004641 RID: 17985
				// (get) Token: 0x0600E27D RID: 57981 RVA: 0x003530C4 File Offset: 0x003512C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E27E RID: 57982 RVA: 0x00353104 File Offset: 0x00351304
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172069, XrefRangeEnd = 172074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004642 RID: 17986
				// (get) Token: 0x0600E27F RID: 57983 RVA: 0x00353138 File Offset: 0x00351338
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E280 RID: 57984 RVA: 0x0006E6C4 File Offset: 0x0006C8C4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700463D RID: 17981
				// (get) Token: 0x0600E281 RID: 57985 RVA: 0x00353178 File Offset: 0x00351378
				// (set) Token: 0x0600E282 RID: 57986 RVA: 0x0006E6CD File Offset: 0x0006C8CD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700463E RID: 17982
				// (get) Token: 0x0600E283 RID: 57987 RVA: 0x003531A0 File Offset: 0x003513A0
				// (set) Token: 0x0600E284 RID: 57988 RVA: 0x0006E6E8 File Offset: 0x0006C8E8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700463F RID: 17983
				// (get) Token: 0x0600E285 RID: 57989 RVA: 0x003531D0 File Offset: 0x003513D0
				// (set) Token: 0x0600E286 RID: 57990 RVA: 0x0006E707 File Offset: 0x0006C907
				public unsafe PlayerCamera.__c__DisplayClass139_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass139_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004640 RID: 17984
				// (get) Token: 0x0600E287 RID: 57991 RVA: 0x00353200 File Offset: 0x00351400
				// (set) Token: 0x0600E288 RID: 57992 RVA: 0x0006E726 File Offset: 0x0006C926
				public unsafe float _duration_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2)) = value;
					}
				}

				// Token: 0x04009796 RID: 38806
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009797 RID: 38807
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009798 RID: 38808
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009799 RID: 38809
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__2;

				// Token: 0x0400979A RID: 38810
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400979B RID: 38811
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400979C RID: 38812
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400979D RID: 38813
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400979E RID: 38814
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400979F RID: 38815
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000999 RID: 2457
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass141_0")]
		public sealed class __c__DisplayClass141_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CABF RID: 51903 RVA: 0x00310134 File Offset: 0x0030E334
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass141_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass141_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "intensity");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "decreaseOverTime");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, 100673292);
				PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, 100673293);
			}

			// Token: 0x0600CAC0 RID: 51904 RVA: 0x003101D8 File Offset: 0x0030E3D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass141_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAC1 RID: 51905 RVA: 0x00310214 File Offset: 0x0030E414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172094, XrefRangeEnd = 172099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CAC2 RID: 51906 RVA: 0x000628E2 File Offset: 0x00060AE2
			public __c__DisplayClass141_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F23 RID: 16163
			// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x00310254 File Offset: 0x0030E454
			// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x000628EB File Offset: 0x00060AEB
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17003F24 RID: 16164
			// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x0031027C File Offset: 0x0030E47C
			// (set) Token: 0x0600CAC6 RID: 51910 RVA: 0x00062906 File Offset: 0x00060B06
			public unsafe float intensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x17003F25 RID: 16165
			// (get) Token: 0x0600CAC7 RID: 51911 RVA: 0x003102A4 File Offset: 0x0030E4A4
			// (set) Token: 0x0600CAC8 RID: 51912 RVA: 0x00062921 File Offset: 0x00060B21
			public unsafe bool decreaseOverTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime)) = value;
				}
			}

			// Token: 0x17003F26 RID: 16166
			// (get) Token: 0x0600CAC9 RID: 51913 RVA: 0x003102CC File Offset: 0x0030E4CC
			// (set) Token: 0x0600CACA RID: 51914 RVA: 0x0006293C File Offset: 0x00060B3C
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008920 RID: 35104
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008921 RID: 35105
			private static readonly IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008922 RID: 35106
			private static readonly IntPtr NativeFieldInfoPtr_decreaseOverTime;

			// Token: 0x04008923 RID: 35107
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008924 RID: 35108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008925 RID: 35109
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C46 RID: 3142
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass141_0+<<StartCameraShake>g__Shake|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E289 RID: 57993 RVA: 0x00353228 File Offset: 0x00351428
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "<<StartCameraShake>g__Shake|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<timeRemaining>5__2");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673294);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673295);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673296);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673297);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673298);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673299);
				}

				// Token: 0x0600E28A RID: 57994 RVA: 0x0035331C File Offset: 0x0035151C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E28B RID: 57995 RVA: 0x00353364 File Offset: 0x00351564
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E28C RID: 57996 RVA: 0x00353398 File Offset: 0x00351598
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172079, XrefRangeEnd = 172089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004647 RID: 17991
				// (get) Token: 0x0600E28D RID: 57997 RVA: 0x003533D4 File Offset: 0x003515D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E28E RID: 57998 RVA: 0x00353414 File Offset: 0x00351614
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172089, XrefRangeEnd = 172094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004648 RID: 17992
				// (get) Token: 0x0600E28F RID: 57999 RVA: 0x00353448 File Offset: 0x00351648
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E290 RID: 58000 RVA: 0x0006E741 File Offset: 0x0006C941
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004643 RID: 17987
				// (get) Token: 0x0600E291 RID: 58001 RVA: 0x00353488 File Offset: 0x00351688
				// (set) Token: 0x0600E292 RID: 58002 RVA: 0x0006E74A File Offset: 0x0006C94A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004644 RID: 17988
				// (get) Token: 0x0600E293 RID: 58003 RVA: 0x003534B0 File Offset: 0x003516B0
				// (set) Token: 0x0600E294 RID: 58004 RVA: 0x0006E765 File Offset: 0x0006C965
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004645 RID: 17989
				// (get) Token: 0x0600E295 RID: 58005 RVA: 0x003534E0 File Offset: 0x003516E0
				// (set) Token: 0x0600E296 RID: 58006 RVA: 0x0006E784 File Offset: 0x0006C984
				public unsafe PlayerCamera.__c__DisplayClass141_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass141_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004646 RID: 17990
				// (get) Token: 0x0600E297 RID: 58007 RVA: 0x00353510 File Offset: 0x00351710
				// (set) Token: 0x0600E298 RID: 58008 RVA: 0x0006E7A3 File Offset: 0x0006C9A3
				public unsafe float _timeRemaining_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2)) = value;
					}
				}

				// Token: 0x040097A0 RID: 38816
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097A1 RID: 38817
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097A2 RID: 38818
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097A3 RID: 38819
				private static readonly IntPtr NativeFieldInfoPtr__timeRemaining_5__2;

				// Token: 0x040097A4 RID: 38820
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097A5 RID: 38821
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097A6 RID: 38822
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097A7 RID: 38823
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097A8 RID: 38824
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097A9 RID: 38825
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200099A RID: 2458
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpCamera>d__115")]
		public sealed class _ILerpCamera_d__115 : Il2CppSystem.Object
		{
			// Token: 0x0600CACB RID: 51915 RVA: 0x003102FC File Offset: 0x0030E4FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpCamera_d__115()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpCamera>d__115");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr);
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "worldSpace");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "returnToRestingPosition");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "endPos");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "endRot");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "reenableLook");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<startPos>5__2");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<startRot>5__3");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<elapsed>5__4");
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673300);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673301);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673302);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673303);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673304);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673305);
			}

			// Token: 0x0600CACC RID: 51916 RVA: 0x00310490 File Offset: 0x0030E690
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpCamera_d__115(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CACD RID: 51917 RVA: 0x003104D8 File Offset: 0x0030E6D8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CACE RID: 51918 RVA: 0x0031050C File Offset: 0x0030E70C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172099, XrefRangeEnd = 172138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F33 RID: 16179
			// (get) Token: 0x0600CACF RID: 51919 RVA: 0x00310548 File Offset: 0x0030E748
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAD0 RID: 51920 RVA: 0x00310588 File Offset: 0x0030E788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172138, XrefRangeEnd = 172143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F34 RID: 16180
			// (get) Token: 0x0600CAD1 RID: 51921 RVA: 0x003105BC File Offset: 0x0030E7BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAD2 RID: 51922 RVA: 0x0006295B File Offset: 0x00060B5B
			public _ILerpCamera_d__115(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F27 RID: 16167
			// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x003105FC File Offset: 0x0030E7FC
			// (set) Token: 0x0600CAD4 RID: 51924 RVA: 0x00062964 File Offset: 0x00060B64
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F28 RID: 16168
			// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x00310624 File Offset: 0x0030E824
			// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x0006297F File Offset: 0x00060B7F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F29 RID: 16169
			// (get) Token: 0x0600CAD7 RID: 51927 RVA: 0x00310654 File Offset: 0x0030E854
			// (set) Token: 0x0600CAD8 RID: 51928 RVA: 0x0006299E File Offset: 0x00060B9E
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2A RID: 16170
			// (get) Token: 0x0600CAD9 RID: 51929 RVA: 0x00310684 File Offset: 0x0030E884
			// (set) Token: 0x0600CADA RID: 51930 RVA: 0x000629BD File Offset: 0x00060BBD
			public unsafe bool worldSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x17003F2B RID: 16171
			// (get) Token: 0x0600CADB RID: 51931 RVA: 0x003106AC File Offset: 0x0030E8AC
			// (set) Token: 0x0600CADC RID: 51932 RVA: 0x000629D8 File Offset: 0x00060BD8
			public unsafe bool returnToRestingPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition)) = value;
				}
			}

			// Token: 0x17003F2C RID: 16172
			// (get) Token: 0x0600CADD RID: 51933 RVA: 0x003106D4 File Offset: 0x0030E8D4
			// (set) Token: 0x0600CADE RID: 51934 RVA: 0x000629F3 File Offset: 0x00060BF3
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F2D RID: 16173
			// (get) Token: 0x0600CADF RID: 51935 RVA: 0x003106FC File Offset: 0x0030E8FC
			// (set) Token: 0x0600CAE0 RID: 51936 RVA: 0x00062A0E File Offset: 0x00060C0E
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17003F2E RID: 16174
			// (get) Token: 0x0600CAE1 RID: 51937 RVA: 0x00310724 File Offset: 0x0030E924
			// (set) Token: 0x0600CAE2 RID: 51938 RVA: 0x00062A29 File Offset: 0x00060C29
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x17003F2F RID: 16175
			// (get) Token: 0x0600CAE3 RID: 51939 RVA: 0x0031074C File Offset: 0x0030E94C
			// (set) Token: 0x0600CAE4 RID: 51940 RVA: 0x00062A44 File Offset: 0x00060C44
			public unsafe bool reenableLook
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook)) = value;
				}
			}

			// Token: 0x17003F30 RID: 16176
			// (get) Token: 0x0600CAE5 RID: 51941 RVA: 0x00310774 File Offset: 0x0030E974
			// (set) Token: 0x0600CAE6 RID: 51942 RVA: 0x00062A5F File Offset: 0x00060C5F
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x17003F31 RID: 16177
			// (get) Token: 0x0600CAE7 RID: 51943 RVA: 0x0031079C File Offset: 0x0030E99C
			// (set) Token: 0x0600CAE8 RID: 51944 RVA: 0x00062A7A File Offset: 0x00060C7A
			public unsafe Quaternion _startRot_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3)) = value;
				}
			}

			// Token: 0x17003F32 RID: 16178
			// (get) Token: 0x0600CAE9 RID: 51945 RVA: 0x003107C4 File Offset: 0x0030E9C4
			// (set) Token: 0x0600CAEA RID: 51946 RVA: 0x00062A95 File Offset: 0x00060C95
			public unsafe float _elapsed_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4)) = value;
				}
			}

			// Token: 0x04008926 RID: 35110
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008927 RID: 35111
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008928 RID: 35112
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008929 RID: 35113
			private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x0400892A RID: 35114
			private static readonly IntPtr NativeFieldInfoPtr_returnToRestingPosition;

			// Token: 0x0400892B RID: 35115
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400892C RID: 35116
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x0400892D RID: 35117
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x0400892E RID: 35118
			private static readonly IntPtr NativeFieldInfoPtr_reenableLook;

			// Token: 0x0400892F RID: 35119
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x04008930 RID: 35120
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__3;

			// Token: 0x04008931 RID: 35121
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__4;

			// Token: 0x04008932 RID: 35122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008933 RID: 35123
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008934 RID: 35124
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008935 RID: 35125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008936 RID: 35126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008937 RID: 35127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200099B RID: 2459
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpFOV>d__126")]
		public sealed class _ILerpFOV_d__126 : Il2CppSystem.Object
		{
			// Token: 0x0600CAEB RID: 51947 RVA: 0x003107EC File Offset: 0x0030E9EC
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpFOV_d__126()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpFOV>d__126");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr);
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "endFov");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<startFov>5__2");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<i>5__3");
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673306);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673307);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673308);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673309);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673310);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673311);
			}

			// Token: 0x0600CAEC RID: 51948 RVA: 0x0031091C File Offset: 0x0030EB1C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpFOV_d__126(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAED RID: 51949 RVA: 0x00310964 File Offset: 0x0030EB64
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAEE RID: 51950 RVA: 0x00310998 File Offset: 0x0030EB98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172143, XrefRangeEnd = 172153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F3C RID: 16188
			// (get) Token: 0x0600CAEF RID: 51951 RVA: 0x003109D4 File Offset: 0x0030EBD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAF0 RID: 51952 RVA: 0x00310A14 File Offset: 0x0030EC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172153, XrefRangeEnd = 172158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F3D RID: 16189
			// (get) Token: 0x0600CAF1 RID: 51953 RVA: 0x00310A48 File Offset: 0x0030EC48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAF2 RID: 51954 RVA: 0x00062AB0 File Offset: 0x00060CB0
			public _ILerpFOV_d__126(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F35 RID: 16181
			// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x00310A88 File Offset: 0x0030EC88
			// (set) Token: 0x0600CAF4 RID: 51956 RVA: 0x00062AB9 File Offset: 0x00060CB9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F36 RID: 16182
			// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x00310AB0 File Offset: 0x0030ECB0
			// (set) Token: 0x0600CAF6 RID: 51958 RVA: 0x00062AD4 File Offset: 0x00060CD4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F37 RID: 16183
			// (get) Token: 0x0600CAF7 RID: 51959 RVA: 0x00310AE0 File Offset: 0x0030ECE0
			// (set) Token: 0x0600CAF8 RID: 51960 RVA: 0x00062AF3 File Offset: 0x00060CF3
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F38 RID: 16184
			// (get) Token: 0x0600CAF9 RID: 51961 RVA: 0x00310B10 File Offset: 0x0030ED10
			// (set) Token: 0x0600CAFA RID: 51962 RVA: 0x00062B12 File Offset: 0x00060D12
			public unsafe float endFov
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov)) = value;
				}
			}

			// Token: 0x17003F39 RID: 16185
			// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x00310B38 File Offset: 0x0030ED38
			// (set) Token: 0x0600CAFC RID: 51964 RVA: 0x00062B2D File Offset: 0x00060D2D
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F3A RID: 16186
			// (get) Token: 0x0600CAFD RID: 51965 RVA: 0x00310B60 File Offset: 0x0030ED60
			// (set) Token: 0x0600CAFE RID: 51966 RVA: 0x00062B48 File Offset: 0x00060D48
			public unsafe float _startFov_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2)) = value;
				}
			}

			// Token: 0x17003F3B RID: 16187
			// (get) Token: 0x0600CAFF RID: 51967 RVA: 0x00310B88 File Offset: 0x0030ED88
			// (set) Token: 0x0600CB00 RID: 51968 RVA: 0x00062B63 File Offset: 0x00060D63
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008938 RID: 35128
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008939 RID: 35129
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400893A RID: 35130
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400893B RID: 35131
			private static readonly IntPtr NativeFieldInfoPtr_endFov;

			// Token: 0x0400893C RID: 35132
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400893D RID: 35133
			private static readonly IntPtr NativeFieldInfoPtr__startFov_5__2;

			// Token: 0x0400893E RID: 35134
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400893F RID: 35135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008940 RID: 35136
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008941 RID: 35137
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008942 RID: 35138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008943 RID: 35139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008944 RID: 35140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200099C RID: 2460
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<LerpDoF>d__123")]
		public sealed class _LerpDoF_d__123 : Il2CppSystem.Object
		{
			// Token: 0x0600CB01 RID: 51969 RVA: 0x00310BB0 File Offset: 0x0030EDB0
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpDoF_d__123()
			{
				Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<LerpDoF>d__123");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr);
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>1__state");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>2__current");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "active");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>4__this");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "lerpTime");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<startFocusDist>5__2");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<endFocusDist>5__3");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<i>5__4");
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673312);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673313);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673314);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673315);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673316);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673317);
			}

			// Token: 0x0600CB02 RID: 51970 RVA: 0x00310CF4 File Offset: 0x0030EEF4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpDoF_d__123(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB03 RID: 51971 RVA: 0x00310D3C File Offset: 0x0030EF3C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB04 RID: 51972 RVA: 0x00310D70 File Offset: 0x0030EF70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172158, XrefRangeEnd = 172167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F46 RID: 16198
			// (get) Token: 0x0600CB05 RID: 51973 RVA: 0x00310DAC File Offset: 0x0030EFAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB06 RID: 51974 RVA: 0x00310DEC File Offset: 0x0030EFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172167, XrefRangeEnd = 172172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F47 RID: 16199
			// (get) Token: 0x0600CB07 RID: 51975 RVA: 0x00310E20 File Offset: 0x0030F020
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB08 RID: 51976 RVA: 0x00062B7E File Offset: 0x00060D7E
			public _LerpDoF_d__123(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F3E RID: 16190
			// (get) Token: 0x0600CB09 RID: 51977 RVA: 0x00310E60 File Offset: 0x0030F060
			// (set) Token: 0x0600CB0A RID: 51978 RVA: 0x00062B87 File Offset: 0x00060D87
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F3F RID: 16191
			// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x00310E88 File Offset: 0x0030F088
			// (set) Token: 0x0600CB0C RID: 51980 RVA: 0x00062BA2 File Offset: 0x00060DA2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F40 RID: 16192
			// (get) Token: 0x0600CB0D RID: 51981 RVA: 0x00310EB8 File Offset: 0x0030F0B8
			// (set) Token: 0x0600CB0E RID: 51982 RVA: 0x00062BC1 File Offset: 0x00060DC1
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x17003F41 RID: 16193
			// (get) Token: 0x0600CB0F RID: 51983 RVA: 0x00310EE0 File Offset: 0x0030F0E0
			// (set) Token: 0x0600CB10 RID: 51984 RVA: 0x00062BDC File Offset: 0x00060DDC
			public unsafe PlayerCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F42 RID: 16194
			// (get) Token: 0x0600CB11 RID: 51985 RVA: 0x00310F10 File Offset: 0x0030F110
			// (set) Token: 0x0600CB12 RID: 51986 RVA: 0x00062BFB File Offset: 0x00060DFB
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F43 RID: 16195
			// (get) Token: 0x0600CB13 RID: 51987 RVA: 0x00310F38 File Offset: 0x0030F138
			// (set) Token: 0x0600CB14 RID: 51988 RVA: 0x00062C16 File Offset: 0x00060E16
			public unsafe float _startFocusDist_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2)) = value;
				}
			}

			// Token: 0x17003F44 RID: 16196
			// (get) Token: 0x0600CB15 RID: 51989 RVA: 0x00310F60 File Offset: 0x0030F160
			// (set) Token: 0x0600CB16 RID: 51990 RVA: 0x00062C31 File Offset: 0x00060E31
			public unsafe float _endFocusDist_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3)) = value;
				}
			}

			// Token: 0x17003F45 RID: 16197
			// (get) Token: 0x0600CB17 RID: 51991 RVA: 0x00310F88 File Offset: 0x0030F188
			// (set) Token: 0x0600CB18 RID: 51992 RVA: 0x00062C4C File Offset: 0x00060E4C
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04008945 RID: 35141
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008946 RID: 35142
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008947 RID: 35143
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x04008948 RID: 35144
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008949 RID: 35145
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400894A RID: 35146
			private static readonly IntPtr NativeFieldInfoPtr__startFocusDist_5__2;

			// Token: 0x0400894B RID: 35147
			private static readonly IntPtr NativeFieldInfoPtr__endFocusDist_5__3;

			// Token: 0x0400894C RID: 35148
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400894D RID: 35149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400894E RID: 35150
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400894F RID: 35151
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008950 RID: 35152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008951 RID: 35153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008952 RID: 35154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
