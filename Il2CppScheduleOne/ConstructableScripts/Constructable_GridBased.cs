using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005CB RID: 1483
	public class Constructable_GridBased : Constructable
	{
		// Token: 0x0600828C RID: 33420 RVA: 0x0022BB64 File Offset: 0x00229D64
		// Note: this type is marked as 'beforefieldinit'.
		static Constructable_GridBased()
		{
			Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "Constructable_GridBased");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr);
			Constructable_GridBased.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "buildPoint");
			Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "CoordinateFootprintTilePairs");
			Constructable_GridBased.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "ContentContainer");
			Constructable_GridBased.NativeFieldInfoPtr_Grids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "Grids");
			Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "roofObjectsForVisibility");
			Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "AlwaysPowered");
			Constructable_GridBased.NativeFieldInfoPtr_powerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "powerNode");
			Constructable_GridBased.NativeFieldInfoPtr_isGhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "isGhost");
			Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "dataChangedThisFrame");
			Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "<OwnerGrid>k__BackingField");
			Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "OwnerGridGUID");
			Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "OriginCoordinate");
			Constructable_GridBased.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "Rotation");
			Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "coordinatePairs");
			Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "originalRoofLayers");
			Constructable_GridBased.NativeFieldInfoPtr_roofVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "roofVisible");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___OwnerGridGUID");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___OriginCoordinate");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___Rotation");
			Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted");
			Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted");
			Constructable_GridBased.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679624);
			Constructable_GridBased.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679625);
			Constructable_GridBased.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679626);
			Constructable_GridBased.NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679627);
			Constructable_GridBased.NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679628);
			Constructable_GridBased.NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679629);
			Constructable_GridBased.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679630);
			Constructable_GridBased.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679631);
			Constructable_GridBased.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679632);
			Constructable_GridBased.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679633);
			Constructable_GridBased.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679634);
			Constructable_GridBased.NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679635);
			Constructable_GridBased.NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679636);
			Constructable_GridBased.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679637);
			Constructable_GridBased.NativeMethodInfoPtr_SetParent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679638);
			Constructable_GridBased.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679639);
			Constructable_GridBased.NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679640);
			Constructable_GridBased.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679641);
			Constructable_GridBased.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679642);
			Constructable_GridBased.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679643);
			Constructable_GridBased.NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679644);
			Constructable_GridBased.NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679645);
			Constructable_GridBased.NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679646);
			Constructable_GridBased.NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679647);
			Constructable_GridBased.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679648);
			Constructable_GridBased.NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679649);
			Constructable_GridBased.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679650);
			Constructable_GridBased.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679651);
			Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679652);
			Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679653);
			Constructable_GridBased.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679654);
			Constructable_GridBased.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679655);
			Constructable_GridBased.NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679656);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679657);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679658);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679659);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679660);
			Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679661);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679662);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679663);
			Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679664);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679665);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679666);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679667);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679668);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679669);
			Constructable_GridBased.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679670);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679671);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679672);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679673);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679674);
			Constructable_GridBased.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679675);
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x0600828D RID: 33421 RVA: 0x0022C148 File Offset: 0x0022A348
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 246130, RefRangeEnd = 246133, XrefRangeStart = 246127, XrefRangeEnd = 246130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600828E RID: 33422 RVA: 0x0022C188 File Offset: 0x0022A388
		public unsafe int FootprintX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246133, XrefRangeEnd = 246137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600828F RID: 33423 RVA: 0x0022C1C4 File Offset: 0x0022A3C4
		public unsafe int FootprintY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246137, XrefRangeEnd = 246141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x0022C200 File Offset: 0x0022A400
		public unsafe bool hasWaterSupply
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x06008291 RID: 33425 RVA: 0x0022C23C File Offset: 0x0022A43C
		public unsafe PowerNode PowerNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr3) : null;
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x0022C27C File Offset: 0x0022A47C
		public unsafe bool isPowered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x06008293 RID: 33427 RVA: 0x0022C2B8 File Offset: 0x0022A4B8
		// (set) Token: 0x06008294 RID: 33428 RVA: 0x0022C2F8 File Offset: 0x0022A4F8
		public unsafe Grid OwnerGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x0022C33C File Offset: 0x0022A53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246142, RefRangeEnd = 246143, XrefRangeStart = 246141, XrefRangeEnd = 246142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x0022C378 File Offset: 0x0022A578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246143, XrefRangeEnd = 246151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x0022C3B4 File Offset: 0x0022A5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246151, XrefRangeEnd = 246166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x0022C404 File Offset: 0x0022A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246166, XrefRangeEnd = 246174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008299 RID: 33433 RVA: 0x0022C440 File Offset: 0x0022A640
		[CallerCount(0)]
		public unsafe virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x0022C4AC File Offset: 0x0022A6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246223, RefRangeEnd = 246224, XrefRangeStart = 246174, XrefRangeEnd = 246223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x0022C4E0 File Offset: 0x0022A6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246224, XrefRangeEnd = 246228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetParent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x0022C524 File Offset: 0x0022A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246228, XrefRangeEnd = 246253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x0022C58C File Offset: 0x0022A78C
		[CallerCount(0)]
		public unsafe virtual void RepositionConstructable(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x0022C5F4 File Offset: 0x0022A7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246253, XrefRangeEnd = 246288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x0022C628 File Offset: 0x0022A828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246288, XrefRangeEnd = 246300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x0022C65C File Offset: 0x0022A85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246342, RefRangeEnd = 246343, XrefRangeStart = 246300, XrefRangeEnd = 246342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A1 RID: 33441 RVA: 0x0022C6A8 File Offset: 0x0022A8A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246367, RefRangeEnd = 246368, XrefRangeStart = 246343, XrefRangeEnd = 246367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGridGUIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x0022C6DC File Offset: 0x0022A8DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246374, RefRangeEnd = 246376, XrefRangeStart = 246368, XrefRangeEnd = 246374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetGridGUIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x0022C71C File Offset: 0x0022A91C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246407, RefRangeEnd = 246409, XrefRangeStart = 246376, XrefRangeEnd = 246407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGridGUIDs(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x0022C770 File Offset: 0x0022A970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246409, XrefRangeEnd = 246424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x0022C7AC File Offset: 0x0022A9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246424, XrefRangeEnd = 246435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RestoreVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0022C7E8 File Offset: 0x0022A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246435, XrefRangeEnd = 246493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRoofVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0022C834 File Offset: 0x0022AA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246498, RefRangeEnd = 246499, XrefRangeStart = 246493, XrefRangeEnd = 246498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0022C868 File Offset: 0x0022AA68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246505, RefRangeEnd = 246508, XrefRangeStart = 246499, XrefRangeEnd = 246505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x0022C8A8 File Offset: 0x0022AAA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246515, RefRangeEnd = 246517, XrefRangeStart = 246508, XrefRangeEnd = 246515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0022C8F8 File Offset: 0x0022AAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246517, XrefRangeEnd = 246533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FootprintTile> GetFootprintTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr3) : null;
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x0022C938 File Offset: 0x0022AB38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246596, RefRangeEnd = 246599, XrefRangeStart = 246533, XrefRangeEnd = 246596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable_GridBased() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x0022C974 File Offset: 0x0022AB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246599, XrefRangeEnd = 246604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x0022C9B4 File Offset: 0x0022ABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ReceiveData_b__36_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0022C9F0 File Offset: 0x0022ABF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246672, RefRangeEnd = 246675, XrefRangeStart = 246604, XrefRangeEnd = 246672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0022CA2C File Offset: 0x0022AC2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246675, RefRangeEnd = 246678, XrefRangeStart = 246675, XrefRangeEnd = 246675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0022CA68 File Offset: 0x0022AC68
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x0022CAA4 File Offset: 0x0022ACA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246678, XrefRangeEnd = 246692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0022CB00 File Offset: 0x0022AD00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246736, RefRangeEnd = 246738, XrefRangeStart = 246692, XrefRangeEnd = 246736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x0022CB68 File Offset: 0x0022AD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246738, XrefRangeEnd = 246745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_810381718(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x0022CBCC File Offset: 0x0022ADCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246745, XrefRangeEnd = 246764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x0022CC20 File Offset: 0x0022AE20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246776, RefRangeEnd = 246778, XrefRangeStart = 246764, XrefRangeEnd = 246776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B6 RID: 33462 RVA: 0x0022CC74 File Offset: 0x0022AE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246778, XrefRangeEnd = 246781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B7 RID: 33463 RVA: 0x0022CCC4 File Offset: 0x0022AEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246781, XrefRangeEnd = 246800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x0022CD18 File Offset: 0x0022AF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246800, XrefRangeEnd = 246804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x060082B9 RID: 33465 RVA: 0x0022CD68 File Offset: 0x0022AF68
		// (set) Token: 0x060082BA RID: 33466 RVA: 0x0022CDA4 File Offset: 0x0022AFA4
		public unsafe Guid SyncAccessor_OwnerGridGUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 246812, RefRangeEnd = 246813, XrefRangeStart = 246804, XrefRangeEnd = 246812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x0022CDF0 File Offset: 0x0022AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246813, XrefRangeEnd = 246833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x0022CE64 File Offset: 0x0022B064
		// (set) Token: 0x060082BD RID: 33469 RVA: 0x0022CEA0 File Offset: 0x0022B0A0
		public unsafe Vector2 SyncAccessor_OriginCoordinate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 246841, RefRangeEnd = 246842, XrefRangeStart = 246833, XrefRangeEnd = 246841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x060082BE RID: 33470 RVA: 0x0022CEEC File Offset: 0x0022B0EC
		// (set) Token: 0x060082BF RID: 33471 RVA: 0x0022CF28 File Offset: 0x0022B128
		public unsafe float SyncAccessor_Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246842, XrefRangeEnd = 246850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x0022CF74 File Offset: 0x0022B174
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 246880, RefRangeEnd = 246883, XrefRangeStart = 246850, XrefRangeEnd = 246880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x0003E14F File Offset: 0x0003C34F
		public Constructable_GridBased(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x060082C2 RID: 33474 RVA: 0x0022CFB0 File Offset: 0x0022B1B0
		// (set) Token: 0x060082C3 RID: 33475 RVA: 0x0003E158 File Offset: 0x0003C358
		public unsafe Transform buildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_buildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x0022CFE0 File Offset: 0x0022B1E0
		// (set) Token: 0x060082C5 RID: 33477 RVA: 0x0003E177 File Offset: 0x0003C377
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x060082C6 RID: 33478 RVA: 0x0022D010 File Offset: 0x0022B210
		// (set) Token: 0x060082C7 RID: 33479 RVA: 0x0003E196 File Offset: 0x0003C396
		public unsafe Transform ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x060082C8 RID: 33480 RVA: 0x0022D040 File Offset: 0x0022B240
		// (set) Token: 0x060082C9 RID: 33481 RVA: 0x0003E1B5 File Offset: 0x0003C3B5
		public unsafe Il2CppReferenceArray<Grid> Grids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Grids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Grids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x060082CA RID: 33482 RVA: 0x0022D070 File Offset: 0x0022B270
		// (set) Token: 0x060082CB RID: 33483 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		public unsafe List<GameObject> roofObjectsForVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x060082CC RID: 33484 RVA: 0x0022D0A0 File Offset: 0x0022B2A0
		// (set) Token: 0x060082CD RID: 33485 RVA: 0x0003E1F3 File Offset: 0x0003C3F3
		public unsafe bool AlwaysPowered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered)) = value;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x060082CE RID: 33486 RVA: 0x0022D0C8 File Offset: 0x0022B2C8
		// (set) Token: 0x060082CF RID: 33487 RVA: 0x0003E20E File Offset: 0x0003C40E
		public unsafe PowerNode powerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_powerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_powerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x060082D0 RID: 33488 RVA: 0x0022D0F8 File Offset: 0x0022B2F8
		// (set) Token: 0x060082D1 RID: 33489 RVA: 0x0003E22D File Offset: 0x0003C42D
		public unsafe bool isGhost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_isGhost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_isGhost)) = value;
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x060082D2 RID: 33490 RVA: 0x0022D120 File Offset: 0x0022B320
		// (set) Token: 0x060082D3 RID: 33491 RVA: 0x0003E248 File Offset: 0x0003C448
		public unsafe bool dataChangedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame)) = value;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x060082D4 RID: 33492 RVA: 0x0022D148 File Offset: 0x0022B348
		// (set) Token: 0x060082D5 RID: 33493 RVA: 0x0003E263 File Offset: 0x0003C463
		public unsafe Grid _OwnerGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x0022D178 File Offset: 0x0022B378
		// (set) Token: 0x060082D7 RID: 33495 RVA: 0x0003E282 File Offset: 0x0003C482
		public unsafe Guid OwnerGridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID)) = value;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x060082D8 RID: 33496 RVA: 0x0022D1A0 File Offset: 0x0022B3A0
		// (set) Token: 0x060082D9 RID: 33497 RVA: 0x0003E29D File Offset: 0x0003C49D
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x060082DA RID: 33498 RVA: 0x0022D1C8 File Offset: 0x0022B3C8
		// (set) Token: 0x060082DB RID: 33499 RVA: 0x0003E2B8 File Offset: 0x0003C4B8
		public unsafe float Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x060082DC RID: 33500 RVA: 0x0022D1F0 File Offset: 0x0022B3F0
		// (set) Token: 0x060082DD RID: 33501 RVA: 0x0003E2D3 File Offset: 0x0003C4D3
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x060082DE RID: 33502 RVA: 0x0022D220 File Offset: 0x0022B420
		// (set) Token: 0x060082DF RID: 33503 RVA: 0x0003E2F2 File Offset: 0x0003C4F2
		public unsafe Dictionary<GameObject, LayerMask> originalRoofLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, LayerMask>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x060082E0 RID: 33504 RVA: 0x0022D250 File Offset: 0x0022B450
		// (set) Token: 0x060082E1 RID: 33505 RVA: 0x0003E311 File Offset: 0x0003C511
		public unsafe bool roofVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofVisible)) = value;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x0022D278 File Offset: 0x0022B478
		// (set) Token: 0x060082E3 RID: 33507 RVA: 0x0003E32C File Offset: 0x0003C52C
		public unsafe SyncVar<Guid> syncVar___OwnerGridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Guid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x0022D2A8 File Offset: 0x0022B4A8
		// (set) Token: 0x060082E5 RID: 33509 RVA: 0x0003E34B File Offset: 0x0003C54B
		public unsafe SyncVar<Vector2> syncVar___OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x060082E6 RID: 33510 RVA: 0x0022D2D8 File Offset: 0x0022B4D8
		// (set) Token: 0x060082E7 RID: 33511 RVA: 0x0003E36A File Offset: 0x0003C56A
		public unsafe SyncVar<float> syncVar___Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x0022D308 File Offset: 0x0022B508
		// (set) Token: 0x060082E9 RID: 33513 RVA: 0x0003E389 File Offset: 0x0003C589
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x060082EA RID: 33514 RVA: 0x0022D330 File Offset: 0x0022B530
		// (set) Token: 0x060082EB RID: 33515 RVA: 0x0003E3A4 File Offset: 0x0003C5A4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040058D2 RID: 22738
		private static readonly IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x040058D3 RID: 22739
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x040058D4 RID: 22740
		private static readonly IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x040058D5 RID: 22741
		private static readonly IntPtr NativeFieldInfoPtr_Grids;

		// Token: 0x040058D6 RID: 22742
		private static readonly IntPtr NativeFieldInfoPtr_roofObjectsForVisibility;

		// Token: 0x040058D7 RID: 22743
		private static readonly IntPtr NativeFieldInfoPtr_AlwaysPowered;

		// Token: 0x040058D8 RID: 22744
		private static readonly IntPtr NativeFieldInfoPtr_powerNode;

		// Token: 0x040058D9 RID: 22745
		private static readonly IntPtr NativeFieldInfoPtr_isGhost;

		// Token: 0x040058DA RID: 22746
		private static readonly IntPtr NativeFieldInfoPtr_dataChangedThisFrame;

		// Token: 0x040058DB RID: 22747
		private static readonly IntPtr NativeFieldInfoPtr__OwnerGrid_k__BackingField;

		// Token: 0x040058DC RID: 22748
		private static readonly IntPtr NativeFieldInfoPtr_OwnerGridGUID;

		// Token: 0x040058DD RID: 22749
		private static readonly IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x040058DE RID: 22750
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x040058DF RID: 22751
		private static readonly IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x040058E0 RID: 22752
		private static readonly IntPtr NativeFieldInfoPtr_originalRoofLayers;

		// Token: 0x040058E1 RID: 22753
		private static readonly IntPtr NativeFieldInfoPtr_roofVisible;

		// Token: 0x040058E2 RID: 22754
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___OwnerGridGUID;

		// Token: 0x040058E3 RID: 22755
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___OriginCoordinate;

		// Token: 0x040058E4 RID: 22756
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___Rotation;

		// Token: 0x040058E5 RID: 22757
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040058E6 RID: 22758
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040058E7 RID: 22759
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x040058E8 RID: 22760
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x040058E9 RID: 22761
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x040058EA RID: 22762
		private static readonly IntPtr NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0;

		// Token: 0x040058EB RID: 22763
		private static readonly IntPtr NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0;

		// Token: 0x040058EC RID: 22764
		private static readonly IntPtr NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0;

		// Token: 0x040058ED RID: 22765
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0;

		// Token: 0x040058EE RID: 22766
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0;

		// Token: 0x040058EF RID: 22767
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040058F0 RID: 22768
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040058F1 RID: 22769
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040058F2 RID: 22770
		private static readonly IntPtr NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0;

		// Token: 0x040058F3 RID: 22771
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0;

		// Token: 0x040058F4 RID: 22772
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x040058F5 RID: 22773
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Private_Void_Transform_0;

		// Token: 0x040058F6 RID: 22774
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x040058F7 RID: 22775
		private static readonly IntPtr NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x040058F8 RID: 22776
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x040058F9 RID: 22777
		private static readonly IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x040058FA RID: 22778
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x040058FB RID: 22779
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0;

		// Token: 0x040058FC RID: 22780
		private static readonly IntPtr NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0;

		// Token: 0x040058FD RID: 22781
		private static readonly IntPtr NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x040058FE RID: 22782
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0;

		// Token: 0x040058FF RID: 22783
		private static readonly IntPtr NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0;

		// Token: 0x04005900 RID: 22784
		private static readonly IntPtr NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005901 RID: 22785
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0;

		// Token: 0x04005902 RID: 22786
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04005903 RID: 22787
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04005904 RID: 22788
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0;

		// Token: 0x04005905 RID: 22789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005906 RID: 22790
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005907 RID: 22791
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0;

		// Token: 0x04005908 RID: 22792
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005909 RID: 22793
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400590A RID: 22794
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400590B RID: 22795
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0;

		// Token: 0x0400590C RID: 22796
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x0400590D RID: 22797
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400590E RID: 22798
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x0400590F RID: 22799
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005910 RID: 22800
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005911 RID: 22801
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005912 RID: 22802
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005913 RID: 22803
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0;

		// Token: 0x04005914 RID: 22804
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0;

		// Token: 0x04005915 RID: 22805
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04005916 RID: 22806
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0;

		// Token: 0x04005917 RID: 22807
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0;

		// Token: 0x04005918 RID: 22808
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0;

		// Token: 0x04005919 RID: 22809
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0;

		// Token: 0x0400591A RID: 22810
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000AE3 RID: 2787
		[ObfuscatedName("ScheduleOne.ConstructableScripts.Constructable_GridBased+<<ReceiveData>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D52A RID: 54570 RVA: 0x0032D1A4 File Offset: 0x0032B3A4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique()
			{
				Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "<<ReceiveData>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>1__state");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>2__current");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>4__this");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679676);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679677);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679678);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679679);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679680);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100679681);
			}

			// Token: 0x0600D52B RID: 54571 RVA: 0x0032D284 File Offset: 0x0032B484
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D52C RID: 54572 RVA: 0x0032D2CC File Offset: 0x0032B4CC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D52D RID: 54573 RVA: 0x0032D300 File Offset: 0x0032B500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246111, XrefRangeEnd = 246122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004210 RID: 16912
			// (get) Token: 0x0600D52E RID: 54574 RVA: 0x0032D33C File Offset: 0x0032B53C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D52F RID: 54575 RVA: 0x0032D37C File Offset: 0x0032B57C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246122, XrefRangeEnd = 246127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004211 RID: 16913
			// (get) Token: 0x0600D530 RID: 54576 RVA: 0x0032D3B0 File Offset: 0x0032B5B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D531 RID: 54577 RVA: 0x00067B83 File Offset: 0x00065D83
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700420D RID: 16909
			// (get) Token: 0x0600D532 RID: 54578 RVA: 0x0032D3F0 File Offset: 0x0032B5F0
			// (set) Token: 0x0600D533 RID: 54579 RVA: 0x00067B8C File Offset: 0x00065D8C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700420E RID: 16910
			// (get) Token: 0x0600D534 RID: 54580 RVA: 0x0032D418 File Offset: 0x0032B618
			// (set) Token: 0x0600D535 RID: 54581 RVA: 0x00067BA7 File Offset: 0x00065DA7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420F RID: 16911
			// (get) Token: 0x0600D536 RID: 54582 RVA: 0x0032D448 File Offset: 0x0032B648
			// (set) Token: 0x0600D537 RID: 54583 RVA: 0x00067BC6 File Offset: 0x00065DC6
			public unsafe Constructable_GridBased __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F64 RID: 36708
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F65 RID: 36709
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F66 RID: 36710
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F67 RID: 36711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F68 RID: 36712
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F69 RID: 36713
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F6A RID: 36714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F6B RID: 36715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F6C RID: 36716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
