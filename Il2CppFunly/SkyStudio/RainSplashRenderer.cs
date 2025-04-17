using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012D RID: 301
	public class RainSplashRenderer : BaseSpriteInstancedRenderer
	{
		// Token: 0x06001993 RID: 6547 RVA: 0x000C0764 File Offset: 0x000BE964
		// Note: this type is marked as 'beforefieldinit'.
		static RainSplashRenderer()
		{
			Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "RainSplashRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr);
			RainSplashRenderer.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_DepthCamera");
			RainSplashRenderer.NativeFieldInfoPtr_m_StartSplashYPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_StartSplashYPositions");
			RainSplashRenderer.NativeFieldInfoPtr_m_DepthUs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_DepthUs");
			RainSplashRenderer.NativeFieldInfoPtr_m_DepthVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_DepthVs");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashAreaStart");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashAreaLength");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashScale");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashScaleVarience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashScaleVarience");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashItensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashItensity");
			RainSplashRenderer.NativeFieldInfoPtr_m_SplashSurfaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SplashSurfaceOffset");
			RainSplashRenderer.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_SkyProfile");
			RainSplashRenderer.NativeFieldInfoPtr_m_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_TimeOfDay");
			RainSplashRenderer.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_Style");
			RainSplashRenderer.NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, "m_Bounds");
			RainSplashRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666019);
			RainSplashRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666020);
			RainSplashRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666021);
			RainSplashRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666022);
			RainSplashRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666023);
			RainSplashRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666024);
			RainSplashRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666025);
			RainSplashRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666026);
			RainSplashRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666027);
			RainSplashRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_RainSplashArtItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666028);
			RainSplashRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666029);
			RainSplashRenderer.NativeMethodInfoPtr_CreateWorldSplashPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666030);
			RainSplashRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr, 100666031);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000C09B0 File Offset: 0x000BEBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96506, XrefRangeEnd = 96532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000C09E4 File Offset: 0x000BEBE4
		[CallerCount(0)]
		public unsafe override Bounds CalculateMeshBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000C0A2C File Offset: 0x000BEC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96532, XrefRangeEnd = 96536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseSpriteItemData CreateSpriteItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseSpriteItemData>(intPtr3) : null;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000C0A78 File Offset: 0x000BEC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96536, XrefRangeEnd = 96548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRenderingEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000C0AC0 File Offset: 0x000BECC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96548, XrefRangeEnd = 96549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNextSpawnCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000C0B08 File Offset: 0x000BED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96549, XrefRangeEnd = 96552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spritePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000C0B80 File Offset: 0x000BED80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96552, XrefRangeEnd = 96562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000C0BD0 File Offset: 0x000BEDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96562, XrefRangeEnd = 96568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000C0C2C File Offset: 0x000BEE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96568, XrefRangeEnd = 96584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(propertyBlock);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RainSplashRenderer.NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			propertyBlock = ((intPtr4 == 0) ? null : new MaterialPropertyBlock(intPtr4));
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000C0C90 File Offset: 0x000BEE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96584, XrefRangeEnd = 96591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_RainSplashArtItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000C0CF4 File Offset: 0x000BEEF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96618, RefRangeEnd = 96620, XrefRangeStart = 96591, XrefRangeEnd = 96618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDataFromSkyProfile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000C0D28 File Offset: 0x000BEF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96620, XrefRangeEnd = 96629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 CreateWorldSplashPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr_CreateWorldSplashPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000C0D64 File Offset: 0x000BEF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96629, XrefRangeEnd = 96642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RainSplashRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainSplashRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RainSplashRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0000E8E9 File Offset: 0x0000CAE9
		public RainSplashRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x000C0DA0 File Offset: 0x000BEFA0
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0000E8F2 File Offset: 0x0000CAF2
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x000C0DD0 File Offset: 0x000BEFD0
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0000E911 File Offset: 0x0000CB11
		public unsafe Il2CppStructArray<float> m_StartSplashYPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_StartSplashYPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_StartSplashYPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x000C0E00 File Offset: 0x000BF000
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0000E930 File Offset: 0x0000CB30
		public unsafe Il2CppStructArray<float> m_DepthUs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthUs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthUs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x000C0E30 File Offset: 0x000BF030
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0000E94F File Offset: 0x0000CB4F
		public unsafe Il2CppStructArray<float> m_DepthVs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthVs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_DepthVs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x000C0E60 File Offset: 0x000BF060
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x0000E96E File Offset: 0x0000CB6E
		public unsafe float m_SplashAreaStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaStart)) = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x000C0E88 File Offset: 0x000BF088
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0000E989 File Offset: 0x0000CB89
		public unsafe float m_SplashAreaLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashAreaLength)) = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x000C0EB0 File Offset: 0x000BF0B0
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		public unsafe float m_SplashScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScale)) = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x000C0ED8 File Offset: 0x000BF0D8
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0000E9BF File Offset: 0x0000CBBF
		public unsafe float m_SplashScaleVarience
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScaleVarience);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashScaleVarience)) = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000C0F00 File Offset: 0x000BF100
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0000E9DA File Offset: 0x0000CBDA
		public unsafe float m_SplashItensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashItensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashItensity)) = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x000C0F28 File Offset: 0x000BF128
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0000E9F5 File Offset: 0x0000CBF5
		public unsafe float m_SplashSurfaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashSurfaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SplashSurfaceOffset)) = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x000C0F50 File Offset: 0x000BF150
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0000EA10 File Offset: 0x0000CC10
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x000C0F80 File Offset: 0x000BF180
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0000EA2F File Offset: 0x0000CC2F
		public unsafe float m_TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_TimeOfDay)) = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x000C0FA8 File Offset: 0x000BF1A8
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0000EA4A File Offset: 0x0000CC4A
		public unsafe RainSplashArtItem m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RainSplashArtItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x000C0FD8 File Offset: 0x000BF1D8
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x0000EA69 File Offset: 0x0000CC69
		public unsafe Bounds m_Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Bounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RainSplashRenderer.NativeFieldInfoPtr_m_Bounds)) = value;
			}
		}

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_m_StartSplashYPositions;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthUs;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthVs;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashAreaStart;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashAreaLength;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashScale;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashScaleVarience;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashItensity;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeFieldInfoPtr_m_SplashSurfaceOffset;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeOfDay;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeFieldInfoPtr_m_Bounds;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMeshBounds_Protected_Virtual_Bounds_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteItemData_Protected_Virtual_BaseSpriteItemData_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderingEnabled_Protected_Virtual_Boolean_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnCount_Protected_Virtual_Int32_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSpriteTRS_Protected_Virtual_Void_BaseSpriteItemData_byref_Vector3_byref_Quaternion_byref_Vector3_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureSpriteItemData_Protected_Virtual_Void_BaseSpriteItemData_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDataArraysForRendering_Protected_Virtual_Void_Int32_BaseSpriteItemData_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePropertyBlockForRendering_Protected_Virtual_Void_byref_MaterialPropertyBlock_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Void_SkyProfile_Single_RainSplashArtItem_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_SyncDataFromSkyProfile_Private_Void_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldSplashPoint_Private_Vector3_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
