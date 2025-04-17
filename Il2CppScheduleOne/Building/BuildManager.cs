using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B2 RID: 1202
	public class BuildManager : Singleton<BuildManager>
	{
		// Token: 0x060069B9 RID: 27065 RVA: 0x001D90F0 File Offset: 0x001D72F0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildManager()
		{
			Il2CppClassPointerStore<BuildManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager>.NativeClassPtr);
			BuildManager.NativeFieldInfoPtr_PlaceSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "PlaceSounds");
			BuildManager.NativeFieldInfoPtr_tempContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "tempContainer");
			BuildManager.NativeFieldInfoPtr_networkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "networkObject");
			BuildManager.NativeFieldInfoPtr_storedItemBuildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "storedItemBuildHandler");
			BuildManager.NativeFieldInfoPtr_cashBuildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "cashBuildHandler");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_White");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_Red");
			BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<isBuilding>k__BackingField");
			BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<currentBuildHandler>k__BackingField");
			BuildManager.NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676720);
			BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676721);
			BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676722);
			BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676723);
			BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676724);
			BuildManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676725);
			BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676726);
			BuildManager.NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676727);
			BuildManager.NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676728);
			BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676729);
			BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676730);
			BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676731);
			BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676732);
			BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676733);
			BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676734);
			BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676735);
			BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676736);
			BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676737);
			BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676738);
			BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676739);
			BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676740);
			BuildManager.NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676741);
			BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676742);
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x060069BA RID: 27066 RVA: 0x001D93A0 File Offset: 0x001D75A0
		public unsafe Transform _tempContainer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x060069BB RID: 27067 RVA: 0x001D93E0 File Offset: 0x001D75E0
		// (set) Token: 0x060069BC RID: 27068 RVA: 0x001D941C File Offset: 0x001D761C
		public unsafe bool isBuilding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x060069BD RID: 27069 RVA: 0x001D945C File Offset: 0x001D765C
		// (set) Token: 0x060069BE RID: 27070 RVA: 0x001D949C File Offset: 0x001D769C
		public unsafe GameObject currentBuildHandler
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x001D94E0 File Offset: 0x001D76E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212927, XrefRangeEnd = 212930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x001D951C File Offset: 0x001D771C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212966, RefRangeEnd = 212968, XrefRangeStart = 212930, XrefRangeEnd = 212966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x001D9560 File Offset: 0x001D7760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212994, RefRangeEnd = 212995, XrefRangeStart = 212968, XrefRangeEnd = 212994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuildingStoredItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x001D95A4 File Offset: 0x001D77A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213015, RefRangeEnd = 213016, XrefRangeStart = 212995, XrefRangeEnd = 213015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPlacingCash(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x001D95E8 File Offset: 0x001D77E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 213020, RefRangeEnd = 213027, XrefRangeStart = 213016, XrefRangeEnd = 213020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBuilding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x001D961C File Offset: 0x001D781C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213042, RefRangeEnd = 213044, XrefRangeStart = 213027, XrefRangeEnd = 213042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x001D9668 File Offset: 0x001D7868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213049, RefRangeEnd = 213051, XrefRangeStart = 213044, XrefRangeEnd = 213049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableColliders(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x001D96AC File Offset: 0x001D78AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213051, XrefRangeEnd = 213056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLights(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x001D96F0 File Offset: 0x001D78F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213064, RefRangeEnd = 213068, XrefRangeStart = 213056, XrefRangeEnd = 213064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNetworking(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x001D9734 File Offset: 0x001D7934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213068, XrefRangeEnd = 213073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSpriteRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x001D9778 File Offset: 0x001D7978
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 213092, RefRangeEnd = 213099, XrefRangeStart = 213073, XrefRangeEnd = 213092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allMaterials;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x001D97DC File Offset: 0x001D79DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213114, RefRangeEnd = 213118, XrefRangeStart = 213099, XrefRangeEnd = 213114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNavigation(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x001D9820 File Offset: 0x001D7A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213118, XrefRangeEnd = 213123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCanvases(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x001D9864 File Offset: 0x001D7A64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213161, RefRangeEnd = 213163, XrefRangeStart = 213123, XrefRangeEnd = 213161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x001D98F8 File Offset: 0x001D7AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213163, XrefRangeEnd = 213192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr3) : null;
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x001D997C File Offset: 0x001D7B7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213222, RefRangeEnd = 213224, XrefRangeStart = 213192, XrefRangeEnd = 213222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSurface);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x001D9A10 File Offset: 0x001D7C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213224, XrefRangeEnd = 213239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem(StorableItemInstance item, IStorageEntity parentStorageEntity, StorageGrid grid, Vector2 originCoord, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentStorageEntity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x001D9A94 File Offset: 0x001D7C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213239, XrefRangeEnd = 213249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x00031FC0 File Offset: 0x000301C0
		public BuildManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x001D9AD0 File Offset: 0x001D7CD0
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x00031FC9 File Offset: 0x000301C9
		public unsafe List<BuildManager.BuildSound> PlaceSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildManager.BuildSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x001D9B00 File Offset: 0x001D7D00
		// (set) Token: 0x060069D5 RID: 27093 RVA: 0x00031FE8 File Offset: 0x000301E8
		public unsafe Transform tempContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_tempContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_tempContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x060069D6 RID: 27094 RVA: 0x001D9B30 File Offset: 0x001D7D30
		// (set) Token: 0x060069D7 RID: 27095 RVA: 0x00032007 File Offset: 0x00030207
		public unsafe NetworkObject networkObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_networkObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_networkObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001D9B60 File Offset: 0x001D7D60
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x00032026 File Offset: 0x00030226
		public unsafe GameObject storedItemBuildHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_storedItemBuildHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_storedItemBuildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x001D9B90 File Offset: 0x001D7D90
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x00032045 File Offset: 0x00030245
		public unsafe GameObject cashBuildHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_cashBuildHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_cashBuildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x001D9BC0 File Offset: 0x001D7DC0
		// (set) Token: 0x060069DD RID: 27101 RVA: 0x00032064 File Offset: 0x00030264
		public unsafe Material ghostMaterial_White
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x060069DE RID: 27102 RVA: 0x001D9BF0 File Offset: 0x001D7DF0
		// (set) Token: 0x060069DF RID: 27103 RVA: 0x00032083 File Offset: 0x00030283
		public unsafe Material ghostMaterial_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x060069E0 RID: 27104 RVA: 0x001D9C20 File Offset: 0x001D7E20
		// (set) Token: 0x060069E1 RID: 27105 RVA: 0x000320A2 File Offset: 0x000302A2
		public unsafe bool _isBuilding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x060069E2 RID: 27106 RVA: 0x001D9C48 File Offset: 0x001D7E48
		// (set) Token: 0x060069E3 RID: 27107 RVA: 0x000320BD File Offset: 0x000302BD
		public unsafe GameObject _currentBuildHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004868 RID: 18536
		private static readonly IntPtr NativeFieldInfoPtr_PlaceSounds;

		// Token: 0x04004869 RID: 18537
		private static readonly IntPtr NativeFieldInfoPtr_tempContainer;

		// Token: 0x0400486A RID: 18538
		private static readonly IntPtr NativeFieldInfoPtr_networkObject;

		// Token: 0x0400486B RID: 18539
		private static readonly IntPtr NativeFieldInfoPtr_storedItemBuildHandler;

		// Token: 0x0400486C RID: 18540
		private static readonly IntPtr NativeFieldInfoPtr_cashBuildHandler;

		// Token: 0x0400486D RID: 18541
		private static readonly IntPtr NativeFieldInfoPtr_ghostMaterial_White;

		// Token: 0x0400486E RID: 18542
		private static readonly IntPtr NativeFieldInfoPtr_ghostMaterial_Red;

		// Token: 0x0400486F RID: 18543
		private static readonly IntPtr NativeFieldInfoPtr__isBuilding_k__BackingField;

		// Token: 0x04004870 RID: 18544
		private static readonly IntPtr NativeFieldInfoPtr__currentBuildHandler_k__BackingField;

		// Token: 0x04004871 RID: 18545
		private static readonly IntPtr NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0;

		// Token: 0x04004872 RID: 18546
		private static readonly IntPtr NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0;

		// Token: 0x04004873 RID: 18547
		private static readonly IntPtr NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0;

		// Token: 0x04004874 RID: 18548
		private static readonly IntPtr NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0;

		// Token: 0x04004875 RID: 18549
		private static readonly IntPtr NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0;

		// Token: 0x04004876 RID: 18550
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004877 RID: 18551
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0;

		// Token: 0x04004878 RID: 18552
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0;

		// Token: 0x04004879 RID: 18553
		private static readonly IntPtr NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0;

		// Token: 0x0400487A RID: 18554
		private static readonly IntPtr NativeMethodInfoPtr_StopBuilding_Public_Void_0;

		// Token: 0x0400487B RID: 18555
		private static readonly IntPtr NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0;

		// Token: 0x0400487C RID: 18556
		private static readonly IntPtr NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0;

		// Token: 0x0400487D RID: 18557
		private static readonly IntPtr NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0;

		// Token: 0x0400487E RID: 18558
		private static readonly IntPtr NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0;

		// Token: 0x0400487F RID: 18559
		private static readonly IntPtr NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0;

		// Token: 0x04004880 RID: 18560
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0;

		// Token: 0x04004881 RID: 18561
		private static readonly IntPtr NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0;

		// Token: 0x04004882 RID: 18562
		private static readonly IntPtr NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0;

		// Token: 0x04004883 RID: 18563
		private static readonly IntPtr NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04004884 RID: 18564
		private static readonly IntPtr NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04004885 RID: 18565
		private static readonly IntPtr NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0;

		// Token: 0x04004886 RID: 18566
		private static readonly IntPtr NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0;

		// Token: 0x04004887 RID: 18567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A52 RID: 2642
		[Serializable]
		public class BuildSound : Il2CppSystem.Object
		{
			// Token: 0x0600D046 RID: 53318 RVA: 0x0031F6E0 File Offset: 0x0031D8E0
			// Note: this type is marked as 'beforefieldinit'.
			static BuildSound()
			{
				Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "BuildSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr);
				BuildManager.BuildSound.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Type");
				BuildManager.BuildSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Sound");
				BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, 100676743);
			}

			// Token: 0x0600D047 RID: 53319 RVA: 0x0031F748 File Offset: 0x0031D948
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D048 RID: 53320 RVA: 0x000655B8 File Offset: 0x000637B8
			public BuildSound(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B0 RID: 16560
			// (get) Token: 0x0600D049 RID: 53321 RVA: 0x0031F784 File Offset: 0x0031D984
			// (set) Token: 0x0600D04A RID: 53322 RVA: 0x000655C1 File Offset: 0x000637C1
			public unsafe BuildableItemDefinition.EBuildSoundType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x170040B1 RID: 16561
			// (get) Token: 0x0600D04B RID: 53323 RVA: 0x0031F7AC File Offset: 0x0031D9AC
			// (set) Token: 0x0600D04C RID: 53324 RVA: 0x000655DC File Offset: 0x000637DC
			public unsafe AudioSourceController Sound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C8E RID: 35982
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04008C8F RID: 35983
			private static readonly IntPtr NativeFieldInfoPtr_Sound;

			// Token: 0x04008C90 RID: 35984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A53 RID: 2643
		[ObfuscatedName("ScheduleOne.Building.BuildManager+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D04D RID: 53325 RVA: 0x0031F7DC File Offset: 0x0031D9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr);
				BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, "type");
				BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, 100676744);
				BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, 100676745);
			}

			// Token: 0x0600D04E RID: 53326 RVA: 0x0031F844 File Offset: 0x0031DA44
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D04F RID: 53327 RVA: 0x0031F880 File Offset: 0x0031DA80
			[CallerCount(0)]
			public unsafe bool _PlayBuildSound_b__0(BuildManager.BuildSound s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D050 RID: 53328 RVA: 0x000655FB File Offset: 0x000637FB
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B2 RID: 16562
			// (get) Token: 0x0600D051 RID: 53329 RVA: 0x0031F8D0 File Offset: 0x0031DAD0
			// (set) Token: 0x0600D052 RID: 53330 RVA: 0x00065604 File Offset: 0x00063804
			public unsafe BuildableItemDefinition.EBuildSoundType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008C91 RID: 35985
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008C92 RID: 35986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C93 RID: 35987
			private static readonly IntPtr NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0;
		}
	}
}
