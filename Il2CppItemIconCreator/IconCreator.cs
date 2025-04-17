using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppItemIconCreator
{
	// Token: 0x02000160 RID: 352
	public class IconCreator : MonoBehaviour
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x000C8450 File Offset: 0x000C6650
		// Note: this type is marked as 'beforefieldinit'.
		static IconCreator()
		{
			Il2CppClassPointerStore<IconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "IconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreator>.NativeClassPtr);
			IconCreator.NativeFieldInfoPtr_isCreatingIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "isCreatingIcons");
			IconCreator.NativeFieldInfoPtr_useDafaultName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "useDafaultName");
			IconCreator.NativeFieldInfoPtr_includeResolutionInFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "includeResolutionInFileName");
			IconCreator.NativeFieldInfoPtr_iconFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "iconFileName");
			IconCreator.NativeFieldInfoPtr_pathLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "pathLocation");
			IconCreator.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mode");
			IconCreator.NativeFieldInfoPtr_folderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "folderName");
			IconCreator.NativeFieldInfoPtr_useTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "useTransparency");
			IconCreator.NativeFieldInfoPtr_lookAtObjectCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "lookAtObjectCenter");
			IconCreator.NativeFieldInfoPtr_dynamicFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "dynamicFov");
			IconCreator.NativeFieldInfoPtr_fovOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "fovOffset");
			IconCreator.NativeFieldInfoPtr_finalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "finalPath");
			IconCreator.NativeFieldInfoPtr_mousePostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mousePostion");
			IconCreator.NativeFieldInfoPtr_nextIconKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "nextIconKey");
			IconCreator.NativeFieldInfoPtr_CanMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "CanMove");
			IconCreator.NativeFieldInfoPtr_preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "preview");
			IconCreator.NativeFieldInfoPtr_whiteCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "whiteCam");
			IconCreator.NativeFieldInfoPtr_blackCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "blackCam");
			IconCreator.NativeFieldInfoPtr_mainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mainCam");
			IconCreator.NativeFieldInfoPtr_texBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "texBlack");
			IconCreator.NativeFieldInfoPtr_texWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "texWhite");
			IconCreator.NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "finalTexture");
			IconCreator.NativeFieldInfoPtr_originalClearFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "originalClearFlags");
			IconCreator.NativeFieldInfoPtr_currentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "currentObject");
			IconCreator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666248);
			IconCreator.NativeMethodInfoPtr_Initialize_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666249);
			IconCreator.NativeMethodInfoPtr_DeleteCameras_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666250);
			IconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666251);
			IconCreator.NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666252);
			IconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666253);
			IconCreator.NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666254);
			IconCreator.NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666255);
			IconCreator.NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666256);
			IconCreator.NativeMethodInfoPtr_GetFinalFolder_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666257);
			IconCreator.NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666258);
			IconCreator.NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666259);
			IconCreator.NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666260);
			IconCreator.NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666261);
			IconCreator.NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666262);
			IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666263);
			IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666264);
			IconCreator.NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666265);
			IconCreator.NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666266);
			IconCreator.NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666267);
			IconCreator.NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666268);
			IconCreator.NativeMethodInfoPtr_RevealInFinder_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666269);
			IconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666270);
			IconCreator.NativeMethodInfoPtr_GetBaseLocation_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666271);
			IconCreator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666272);
			IconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100666273);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000C8868 File Offset: 0x000C6A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100646, XrefRangeEnd = 100670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x000C889C File Offset: 0x000C6A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100705, RefRangeEnd = 100706, XrefRangeStart = 100670, XrefRangeEnd = 100705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_Initialize_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x000C88D0 File Offset: 0x000C6AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100721, RefRangeEnd = 100722, XrefRangeStart = 100706, XrefRangeEnd = 100721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_DeleteCameras_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x000C8904 File Offset: 0x000C6B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100722, XrefRangeEnd = 100728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000C8940 File Offset: 0x000C6B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100734, RefRangeEnd = 100736, XrefRangeStart = 100728, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaptureFrame(string objectName, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000C89A0 File Offset: 0x000C6BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100755, RefRangeEnd = 100757, XrefRangeStart = 100736, XrefRangeEnd = 100755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000C89DC File Offset: 0x000C6BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100757, XrefRangeEnd = 100765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderCamToTexture(Camera cam, Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000C8A30 File Offset: 0x000C6C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100799, RefRangeEnd = 100800, XrefRangeStart = 100765, XrefRangeEnd = 100799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateBlackAndWhiteCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x000C8A64 File Offset: 0x000C6C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100800, XrefRangeEnd = 100824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewFolderForIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000C8A98 File Offset: 0x000C6C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100824, XrefRangeEnd = 100827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFinalFolder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetFinalFolder_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000C8AD0 File Offset: 0x000C6CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100827, XrefRangeEnd = 100832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteScreenImageToTexture(Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000C8B14 File Offset: 0x000C6D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100832, XrefRangeEnd = 100839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateOutputTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x000C8B48 File Offset: 0x000C6D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100839, XrefRangeEnd = 100865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePng(string name, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000C8B98 File Offset: 0x000C6D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100865, XrefRangeEnd = 100878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFileName(string name, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000C8BF0 File Offset: 0x000C6DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100878, XrefRangeEnd = 100898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheAndInitialiseFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x000C8C24 File Offset: 0x000C6E24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100903, RefRangeEnd = 100907, XrefRangeStart = 100898, XrefRangeEnd = 100903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV(GameObject targetItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000C8C68 File Offset: 0x000C6E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100907, XrefRangeEnd = 100914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000C8CA8 File Offset: 0x000C6EA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100928, RefRangeEnd = 100932, XrefRangeStart = 100914, XrefRangeEnd = 100928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAtTargetCenter(GameObject targetItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000C8CEC File Offset: 0x000C6EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100987, RefRangeEnd = 100988, XrefRangeStart = 100932, XrefRangeEnd = 100987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetFov(GameObject a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000C8D3C File Offset: 0x000C6F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101009, RefRangeEnd = 101011, XrefRangeStart = 100988, XrefRangeEnd = 101009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Renderer> GetRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Renderer>>(intPtr3) : null;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000C8D8C File Offset: 0x000C6F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101022, RefRangeEnd = 101023, XrefRangeStart = 101011, XrefRangeEnd = 101022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMeshCenter(GameObject a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000C8DDC File Offset: 0x000C6FDC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevealInFinder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_RevealInFinder_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000C8E10 File Offset: 0x000C7010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101034, RefRangeEnd = 101036, XrefRangeStart = 101023, XrefRangeEnd = 101034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000C8E58 File Offset: 0x000C7058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101040, RefRangeEnd = 101043, XrefRangeStart = 101036, XrefRangeEnd = 101040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBaseLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetBaseLocation_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000C8E90 File Offset: 0x000C7090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101043, XrefRangeEnd = 101051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000C8EC4 File Offset: 0x000C70C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101051, XrefRangeEnd = 101056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x000101FA File Offset: 0x0000E3FA
		public IconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x000C8F00 File Offset: 0x000C7100
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x00010203 File Offset: 0x0000E403
		public unsafe bool isCreatingIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_isCreatingIcons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_isCreatingIcons)) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000C8F28 File Offset: 0x000C7128
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0001021E File Offset: 0x0000E41E
		public unsafe bool useDafaultName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useDafaultName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useDafaultName)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000C8F50 File Offset: 0x000C7150
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x00010239 File Offset: 0x0000E439
		public unsafe bool includeResolutionInFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_includeResolutionInFileName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_includeResolutionInFileName)) = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x000C8F78 File Offset: 0x000C7178
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x00010254 File Offset: 0x0000E454
		public unsafe string iconFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_iconFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_iconFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000C8FA0 File Offset: 0x000C71A0
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x00010273 File Offset: 0x0000E473
		public unsafe IconCreator.SaveLocation pathLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_pathLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_pathLocation)) = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x000C8FC8 File Offset: 0x000C71C8
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0001028E File Offset: 0x0000E48E
		public unsafe IconCreator.Mode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000C8FF0 File Offset: 0x000C71F0
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x000102A9 File Offset: 0x0000E4A9
		public unsafe string folderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_folderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_folderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x000C9018 File Offset: 0x000C7218
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x000102C8 File Offset: 0x0000E4C8
		public unsafe bool useTransparency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useTransparency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useTransparency)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x000C9040 File Offset: 0x000C7240
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x000102E3 File Offset: 0x0000E4E3
		public unsafe bool lookAtObjectCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_lookAtObjectCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_lookAtObjectCenter)) = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x000C9068 File Offset: 0x000C7268
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x000102FE File Offset: 0x0000E4FE
		public unsafe bool dynamicFov
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_dynamicFov);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_dynamicFov)) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x000C9090 File Offset: 0x000C7290
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x00010319 File Offset: 0x0000E519
		public unsafe float fovOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_fovOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_fovOffset)) = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000C90B8 File Offset: 0x000C72B8
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x00010334 File Offset: 0x0000E534
		public unsafe string finalPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x000C90E0 File Offset: 0x000C72E0
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x00010353 File Offset: 0x0000E553
		public unsafe Vector3 mousePostion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mousePostion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mousePostion)) = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000C9108 File Offset: 0x000C7308
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0001036E File Offset: 0x0000E56E
		public unsafe KeyCode nextIconKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_nextIconKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_nextIconKey)) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x000C9130 File Offset: 0x000C7330
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x00010389 File Offset: 0x0000E589
		public unsafe bool CanMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_CanMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_CanMove)) = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x000C9158 File Offset: 0x000C7358
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x000103A4 File Offset: 0x0000E5A4
		public unsafe bool preview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_preview);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_preview)) = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x000C9180 File Offset: 0x000C7380
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x000103BF File Offset: 0x0000E5BF
		public unsafe Camera whiteCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_whiteCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_whiteCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x000C91B0 File Offset: 0x000C73B0
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x000103DE File Offset: 0x0000E5DE
		public unsafe Camera blackCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_blackCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_blackCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000C91E0 File Offset: 0x000C73E0
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x000103FD File Offset: 0x0000E5FD
		public unsafe Camera mainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mainCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mainCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000C9210 File Offset: 0x000C7410
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0001041C File Offset: 0x0000E61C
		public unsafe Texture2D texBlack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texBlack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texBlack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x000C9240 File Offset: 0x000C7440
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0001043B File Offset: 0x0000E63B
		public unsafe Texture2D texWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texWhite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texWhite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x000C9270 File Offset: 0x000C7470
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0001045A File Offset: 0x0000E65A
		public unsafe Texture2D finalTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000C92A0 File Offset: 0x000C74A0
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00010479 File Offset: 0x0000E679
		public unsafe CameraClearFlags originalClearFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_originalClearFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_originalClearFlags)) = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000C92C8 File Offset: 0x000C74C8
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00010494 File Offset: 0x0000E694
		public unsafe Transform currentObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_currentObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_currentObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_isCreatingIcons;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_useDafaultName;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_includeResolutionInFileName;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_iconFileName;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_pathLocation;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_folderName;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr_useTransparency;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_lookAtObjectCenter;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_dynamicFov;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_fovOffset;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeFieldInfoPtr_finalPath;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeFieldInfoPtr_mousePostion;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeFieldInfoPtr_nextIconKey;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeFieldInfoPtr_CanMove;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeFieldInfoPtr_preview;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr_whiteCam;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_blackCam;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_mainCam;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_texBlack;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_texWhite;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_finalTexture;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_originalClearFlags;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr_currentObject;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_DeleteCameras_Protected_Void_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFolder_Public_String_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_RevealInFinder_Protected_Void_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseLocation_Private_String_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000863 RID: 2147
		[OriginalName("Assembly-CSharp.dll", "", "SaveLocation")]
		public enum SaveLocation
		{
			// Token: 0x040082A4 RID: 33444
			persistentDataPath,
			// Token: 0x040082A5 RID: 33445
			dataPath,
			// Token: 0x040082A6 RID: 33446
			projectFolder,
			// Token: 0x040082A7 RID: 33447
			custom
		}

		// Token: 0x02000864 RID: 2148
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x040082A9 RID: 33449
			Automatic,
			// Token: 0x040082AA RID: 33450
			Manual
		}

		// Token: 0x02000865 RID: 2149
		[ObfuscatedName("ItemIconCreator.IconCreator+<CaptureFrame>d__30")]
		public sealed class _CaptureFrame_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600C0E6 RID: 49382 RVA: 0x002F1E08 File Offset: 0x002F0008
			// Note: this type is marked as 'beforefieldinit'.
			static _CaptureFrame_d__30()
			{
				Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "<CaptureFrame>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr);
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>1__state");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>2__current");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>4__this");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "objectName");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "i");
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666274);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666275);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666276);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666277);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666278);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100666279);
			}

			// Token: 0x0600C0E7 RID: 49383 RVA: 0x002F1F10 File Offset: 0x002F0110
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaptureFrame_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0E8 RID: 49384 RVA: 0x002F1F58 File Offset: 0x002F0158
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C0E9 RID: 49385 RVA: 0x002F1F8C File Offset: 0x002F018C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100627, XrefRangeEnd = 100641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C1D RID: 15389
			// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x002F1FC8 File Offset: 0x002F01C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C0EB RID: 49387 RVA: 0x002F2008 File Offset: 0x002F0208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100641, XrefRangeEnd = 100646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C1E RID: 15390
			// (get) Token: 0x0600C0EC RID: 49388 RVA: 0x002F203C File Offset: 0x002F023C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C0ED RID: 49389 RVA: 0x0005E4E0 File Offset: 0x0005C6E0
			public _CaptureFrame_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C18 RID: 15384
			// (get) Token: 0x0600C0EE RID: 49390 RVA: 0x002F207C File Offset: 0x002F027C
			// (set) Token: 0x0600C0EF RID: 49391 RVA: 0x0005E4E9 File Offset: 0x0005C6E9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C19 RID: 15385
			// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x002F20A4 File Offset: 0x002F02A4
			// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x0005E504 File Offset: 0x0005C704
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C1A RID: 15386
			// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x002F20D4 File Offset: 0x002F02D4
			// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x0005E523 File Offset: 0x0005C723
			public unsafe IconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C1B RID: 15387
			// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x002F2104 File Offset: 0x002F0304
			// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x0005E542 File Offset: 0x0005C742
			public unsafe string objectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C1C RID: 15388
			// (get) Token: 0x0600C0F6 RID: 49398 RVA: 0x002F212C File Offset: 0x002F032C
			// (set) Token: 0x0600C0F7 RID: 49399 RVA: 0x0005E561 File Offset: 0x0005C761
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x040082AB RID: 33451
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040082AC RID: 33452
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040082AD RID: 33453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040082AE RID: 33454
			private static readonly IntPtr NativeFieldInfoPtr_objectName;

			// Token: 0x040082AF RID: 33455
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040082B0 RID: 33456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040082B1 RID: 33457
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082B2 RID: 33458
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040082B3 RID: 33459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040082B4 RID: 33460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040082B5 RID: 33461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
