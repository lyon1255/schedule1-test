using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007B RID: 123
	public static class BatchingHelper : Il2CppSystem.Object
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0008AE94 File Offset: 0x00089094
		// Note: this type is marked as 'beforefieldinit'.
		static BatchingHelper()
		{
			Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BatchingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr);
			BatchingHelper.NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664215);
			BatchingHelper.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664216);
			BatchingHelper.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664217);
			BatchingHelper.NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664218);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664219);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664220);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664221);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664222);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664223);
			BatchingHelper.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100664224);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0008AF8C File Offset: 0x0008918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79314, XrefRangeEnd = 79316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGpuInstancingEnabled(Material material)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0008AFD0 File Offset: 0x000891D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79318, RefRangeEnd = 79319, XrefRangeStart = 79316, XrefRangeEnd = 79318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableGpuInstancing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0008B014 File Offset: 0x00089214
		public unsafe static bool forceEnableDepthBlend
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 79321, RefRangeEnd = 79325, XrefRangeStart = 79319, XrefRangeEnd = 79321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0008B044 File Offset: 0x00089244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79347, RefRangeEnd = 79349, XrefRangeStart = 79325, XrefRangeEnd = 79347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesRenderingModePreventBatching(ShaderMode shaderMode, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shaderMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0008B0A4 File Offset: 0x000892A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79423, RefRangeEnd = 79424, XrefRangeStart = 79349, XrefRangeEnd = 79423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamSD beamA, VolumetricLightBeamSD beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0008B118 File Offset: 0x00089318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79444, RefRangeEnd = 79446, XrefRangeStart = 79424, XrefRangeEnd = 79444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamSD beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0008B17C File Offset: 0x0008937C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79502, RefRangeEnd = 79503, XrefRangeStart = 79446, XrefRangeEnd = 79502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamHD beamA, VolumetricLightBeamHD beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0008B1F0 File Offset: 0x000893F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79524, RefRangeEnd = 79526, XrefRangeStart = 79503, XrefRangeEnd = 79524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamHD beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0008B254 File Offset: 0x00089454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79526, XrefRangeEnd = 79532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamAbstractBase beamA, VolumetricLightBeamAbstractBase beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0008B2C8 File Offset: 0x000894C8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 79543, RefRangeEnd = 79558, XrefRangeStart = 79532, XrefRangeEnd = 79543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendErrorMessage(ref string message, string toAppend)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toAppend);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00006AC6 File Offset: 0x00004CC6
		public BatchingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0;
	}
}
