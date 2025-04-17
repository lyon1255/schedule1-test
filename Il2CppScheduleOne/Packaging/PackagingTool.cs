using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000567 RID: 1383
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x06007928 RID: 31016 RVA: 0x0020AFC4 File Offset: 0x002091C4
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingTool()
		{
			Il2CppClassPointerStore<PackagingTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "PackagingTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr);
			PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<ReceiveInput>k__BackingField");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Min");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Max");
			PackagingTool.NativeFieldInfoPtr_ConveyorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorSpeed");
			PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorAcceleration");
			PackagingTool.NativeFieldInfoPtr_BaggieRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieRadius");
			PackagingTool.NativeFieldInfoPtr_JarRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarRadius");
			PackagingTool.NativeFieldInfoPtr_DeployAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DeployAngle");
			PackagingTool.NativeFieldInfoPtr_ProductInitialForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInitialForce");
			PackagingTool.NativeFieldInfoPtr_ProductRandomTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductRandomTorque");
			PackagingTool.NativeFieldInfoPtr_KickForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickForce");
			PackagingTool.NativeFieldInfoPtr_DropCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropCooldown");
			PackagingTool.NativeFieldInfoPtr_Station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "Station");
			PackagingTool.NativeFieldInfoPtr_ConveyorModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorModel");
			PackagingTool.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DoorAnim");
			PackagingTool.NativeFieldInfoPtr_CapAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "CapAnim");
			PackagingTool.NativeFieldInfoPtr_SealAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "SealAnim");
			PackagingTool.NativeFieldInfoPtr_KickAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickAnim");
			PackagingTool.NativeFieldInfoPtr_LeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "LeftButton");
			PackagingTool.NativeFieldInfoPtr_RightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "RightButton");
			PackagingTool.NativeFieldInfoPtr_DropButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropButton");
			PackagingTool.NativeFieldInfoPtr_PackagingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingContainer");
			PackagingTool.NativeFieldInfoPtr_ProductCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductCountText");
			PackagingTool.NativeFieldInfoPtr_HopperDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperDropPoint");
			PackagingTool.NativeFieldInfoPtr_BaggieStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieStartPoint");
			PackagingTool.NativeFieldInfoPtr_JarStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarStartPoint");
			PackagingTool.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductContainer");
			PackagingTool.NativeFieldInfoPtr_KickOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickOrigin");
			PackagingTool.NativeFieldInfoPtr_HopperInputCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperInputCollider");
			PackagingTool.NativeFieldInfoPtr_KickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickSound");
			PackagingTool.NativeFieldInfoPtr_MotorSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "MotorSound");
			PackagingTool.NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropSound");
			PackagingTool.NativeFieldInfoPtr_PackagingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingPrefab");
			PackagingTool.NativeFieldInfoPtr_ConcealedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConcealedPackaging");
			PackagingTool.NativeFieldInfoPtr_ProductItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductItem");
			PackagingTool.NativeFieldInfoPtr_ProductPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductPrefab");
			PackagingTool.NativeFieldInfoPtr_ProductInHopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInHopper");
			PackagingTool.NativeFieldInfoPtr_PackagingInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstances");
			PackagingTool.NativeFieldInfoPtr_ProductInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInstances");
			PackagingTool.NativeFieldInfoPtr_FinalizedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizedPackaging");
			PackagingTool.NativeFieldInfoPtr_conveyorVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "conveyorVelocity");
			PackagingTool.NativeFieldInfoPtr_directionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "directionInput");
			PackagingTool.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "task");
			PackagingTool.NativeFieldInfoPtr_finalizeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeInstance");
			PackagingTool.NativeFieldInfoPtr_finalizeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeCoroutine");
			PackagingTool.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "leftDown");
			PackagingTool.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "rightDown");
			PackagingTool.NativeFieldInfoPtr_dropDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "dropDown");
			PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "timeSinceLastDrop");
			PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678486);
			PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678487);
			PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678488);
			PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678489);
			PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678490);
			PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678491);
			PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678492);
			PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678493);
			PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678494);
			PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678495);
			PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678496);
			PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678497);
			PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678498);
			PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678499);
			PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678500);
			PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678501);
			PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678502);
			PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678503);
			PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678504);
			PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678505);
			PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678506);
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x06007929 RID: 31017 RVA: 0x0020B56C File Offset: 0x0020976C
		// (set) Token: 0x0600792A RID: 31018 RVA: 0x0020B5A8 File Offset: 0x002097A8
		public unsafe bool ReceiveInput
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x0020B5E8 File Offset: 0x002097E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232800, RefRangeEnd = 232801, XrefRangeStart = 232789, XrefRangeEnd = 232800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_task);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packagingQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x0020B66C File Offset: 0x0020986C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232847, RefRangeEnd = 232848, XrefRangeStart = 232801, XrefRangeEnd = 232847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x0020B6A0 File Offset: 0x002098A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232848, XrefRangeEnd = 232849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x0020B6F0 File Offset: 0x002098F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232849, XrefRangeEnd = 232850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x0020B724 File Offset: 0x00209924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232850, XrefRangeEnd = 232857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProduct(ProductItemInstance product, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x0020B774 File Offset: 0x00209974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232857, XrefRangeEnd = 232862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x0020B7A8 File Offset: 0x002099A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232862, XrefRangeEnd = 232889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x0020B7DC File Offset: 0x002099DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232908, RefRangeEnd = 232909, XrefRangeStart = 232889, XrefRangeEnd = 232908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x0020B810 File Offset: 0x00209A10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 232913, RefRangeEnd = 232917, XrefRangeStart = 232909, XrefRangeEnd = 232913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x0020B844 File Offset: 0x00209A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232917, XrefRangeEnd = 232921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConveyor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x0020B878 File Offset: 0x00209A78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 232949, RefRangeEnd = 232952, XrefRangeStart = 232921, XrefRangeEnd = 232949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x0020B8B8 File Offset: 0x00209AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232959, RefRangeEnd = 232961, XrefRangeStart = 232952, XrefRangeEnd = 232959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x0020B8EC File Offset: 0x00209AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232961, XrefRangeEnd = 232973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0020B920 File Offset: 0x00209B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232988, RefRangeEnd = 232990, XrefRangeStart = 232973, XrefRangeEnd = 232988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize(PackagingTool.PackagingInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x0020B964 File Offset: 0x00209B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233010, RefRangeEnd = 233011, XrefRangeStart = 232990, XrefRangeEnd = 233010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x0020B998 File Offset: 0x00209B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233032, RefRangeEnd = 233033, XrefRangeStart = 233011, XrefRangeEnd = 233032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInsertions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x0020B9CC File Offset: 0x00209BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233044, RefRangeEnd = 233045, XrefRangeStart = 233033, XrefRangeEnd = 233044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertIntoHopper(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x0020BA10 File Offset: 0x00209C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233121, RefRangeEnd = 233122, XrefRangeStart = 233045, XrefRangeEnd = 233121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x0020BA44 File Offset: 0x00209C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233122, XrefRangeEnd = 233144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x0003988C File Offset: 0x00037A8C
		public PackagingTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x0020BA80 File Offset: 0x00209C80
		// (set) Token: 0x06007940 RID: 31040 RVA: 0x00039895 File Offset: 0x00037A95
		public unsafe bool _ReceiveInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField)) = value;
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x0020BAA8 File Offset: 0x00209CA8
		// (set) Token: 0x06007942 RID: 31042 RVA: 0x000398B0 File Offset: 0x00037AB0
		public unsafe static float FinalizeRange_Min
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&value));
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x06007943 RID: 31043 RVA: 0x0020BAC4 File Offset: 0x00209CC4
		// (set) Token: 0x06007944 RID: 31044 RVA: 0x000398BE File Offset: 0x00037ABE
		public unsafe static float FinalizeRange_Max
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&value));
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x0020BAE0 File Offset: 0x00209CE0
		// (set) Token: 0x06007946 RID: 31046 RVA: 0x000398CC File Offset: 0x00037ACC
		public unsafe float ConveyorSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed)) = value;
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x06007947 RID: 31047 RVA: 0x0020BB08 File Offset: 0x00209D08
		// (set) Token: 0x06007948 RID: 31048 RVA: 0x000398E7 File Offset: 0x00037AE7
		public unsafe float ConveyorAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration)) = value;
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x06007949 RID: 31049 RVA: 0x0020BB30 File Offset: 0x00209D30
		// (set) Token: 0x0600794A RID: 31050 RVA: 0x00039902 File Offset: 0x00037B02
		public unsafe float BaggieRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius)) = value;
			}
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x0600794B RID: 31051 RVA: 0x0020BB58 File Offset: 0x00209D58
		// (set) Token: 0x0600794C RID: 31052 RVA: 0x0003991D File Offset: 0x00037B1D
		public unsafe float JarRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius)) = value;
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600794D RID: 31053 RVA: 0x0020BB80 File Offset: 0x00209D80
		// (set) Token: 0x0600794E RID: 31054 RVA: 0x00039938 File Offset: 0x00037B38
		public unsafe float DeployAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle)) = value;
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600794F RID: 31055 RVA: 0x0020BBA8 File Offset: 0x00209DA8
		// (set) Token: 0x06007950 RID: 31056 RVA: 0x00039953 File Offset: 0x00037B53
		public unsafe float ProductInitialForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce)) = value;
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x06007951 RID: 31057 RVA: 0x0020BBD0 File Offset: 0x00209DD0
		// (set) Token: 0x06007952 RID: 31058 RVA: 0x0003996E File Offset: 0x00037B6E
		public unsafe float ProductRandomTorque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque)) = value;
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x06007953 RID: 31059 RVA: 0x0020BBF8 File Offset: 0x00209DF8
		// (set) Token: 0x06007954 RID: 31060 RVA: 0x00039989 File Offset: 0x00037B89
		public unsafe float KickForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce)) = value;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x06007955 RID: 31061 RVA: 0x0020BC20 File Offset: 0x00209E20
		// (set) Token: 0x06007956 RID: 31062 RVA: 0x000399A4 File Offset: 0x00037BA4
		public unsafe float DropCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown)) = value;
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x06007957 RID: 31063 RVA: 0x0020BC48 File Offset: 0x00209E48
		// (set) Token: 0x06007958 RID: 31064 RVA: 0x000399BF File Offset: 0x00037BBF
		public unsafe PackagingStation Station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x06007959 RID: 31065 RVA: 0x0020BC78 File Offset: 0x00209E78
		// (set) Token: 0x0600795A RID: 31066 RVA: 0x000399DE File Offset: 0x00037BDE
		public unsafe Transform ConveyorModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x0600795B RID: 31067 RVA: 0x0020BCA8 File Offset: 0x00209EA8
		// (set) Token: 0x0600795C RID: 31068 RVA: 0x000399FD File Offset: 0x00037BFD
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x0600795D RID: 31069 RVA: 0x0020BCD8 File Offset: 0x00209ED8
		// (set) Token: 0x0600795E RID: 31070 RVA: 0x00039A1C File Offset: 0x00037C1C
		public unsafe Animation CapAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x0600795F RID: 31071 RVA: 0x0020BD08 File Offset: 0x00209F08
		// (set) Token: 0x06007960 RID: 31072 RVA: 0x00039A3B File Offset: 0x00037C3B
		public unsafe Animation SealAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x06007961 RID: 31073 RVA: 0x0020BD38 File Offset: 0x00209F38
		// (set) Token: 0x06007962 RID: 31074 RVA: 0x00039A5A File Offset: 0x00037C5A
		public unsafe Animation KickAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x06007963 RID: 31075 RVA: 0x0020BD68 File Offset: 0x00209F68
		// (set) Token: 0x06007964 RID: 31076 RVA: 0x00039A79 File Offset: 0x00037C79
		public unsafe Clickable LeftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x06007965 RID: 31077 RVA: 0x0020BD98 File Offset: 0x00209F98
		// (set) Token: 0x06007966 RID: 31078 RVA: 0x00039A98 File Offset: 0x00037C98
		public unsafe Clickable RightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06007967 RID: 31079 RVA: 0x0020BDC8 File Offset: 0x00209FC8
		// (set) Token: 0x06007968 RID: 31080 RVA: 0x00039AB7 File Offset: 0x00037CB7
		public unsafe Clickable DropButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x06007969 RID: 31081 RVA: 0x0020BDF8 File Offset: 0x00209FF8
		// (set) Token: 0x0600796A RID: 31082 RVA: 0x00039AD6 File Offset: 0x00037CD6
		public unsafe Transform PackagingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x0600796B RID: 31083 RVA: 0x0020BE28 File Offset: 0x0020A028
		// (set) Token: 0x0600796C RID: 31084 RVA: 0x00039AF5 File Offset: 0x00037CF5
		public unsafe TextMeshPro ProductCountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x0600796D RID: 31085 RVA: 0x0020BE58 File Offset: 0x0020A058
		// (set) Token: 0x0600796E RID: 31086 RVA: 0x00039B14 File Offset: 0x00037D14
		public unsafe Transform HopperDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x0020BE88 File Offset: 0x0020A088
		// (set) Token: 0x06007970 RID: 31088 RVA: 0x00039B33 File Offset: 0x00037D33
		public unsafe Transform BaggieStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06007971 RID: 31089 RVA: 0x0020BEB8 File Offset: 0x0020A0B8
		// (set) Token: 0x06007972 RID: 31090 RVA: 0x00039B52 File Offset: 0x00037D52
		public unsafe Transform JarStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06007973 RID: 31091 RVA: 0x0020BEE8 File Offset: 0x0020A0E8
		// (set) Token: 0x06007974 RID: 31092 RVA: 0x00039B71 File Offset: 0x00037D71
		public unsafe Transform ProductContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06007975 RID: 31093 RVA: 0x0020BF18 File Offset: 0x0020A118
		// (set) Token: 0x06007976 RID: 31094 RVA: 0x00039B90 File Offset: 0x00037D90
		public unsafe Transform KickOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06007977 RID: 31095 RVA: 0x0020BF48 File Offset: 0x0020A148
		// (set) Token: 0x06007978 RID: 31096 RVA: 0x00039BAF File Offset: 0x00037DAF
		public unsafe SphereCollider HopperInputCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06007979 RID: 31097 RVA: 0x0020BF78 File Offset: 0x0020A178
		// (set) Token: 0x0600797A RID: 31098 RVA: 0x00039BCE File Offset: 0x00037DCE
		public unsafe AudioSourceController KickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x0600797B RID: 31099 RVA: 0x0020BFA8 File Offset: 0x0020A1A8
		// (set) Token: 0x0600797C RID: 31100 RVA: 0x00039BED File Offset: 0x00037DED
		public unsafe AudioSourceController MotorSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x0020BFD8 File Offset: 0x0020A1D8
		// (set) Token: 0x0600797E RID: 31102 RVA: 0x00039C0C File Offset: 0x00037E0C
		public unsafe AudioSourceController DropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x0020C008 File Offset: 0x0020A208
		// (set) Token: 0x06007980 RID: 31104 RVA: 0x00039C2B File Offset: 0x00037E2B
		public unsafe FunctionalPackaging PackagingPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06007981 RID: 31105 RVA: 0x0020C038 File Offset: 0x0020A238
		// (set) Token: 0x06007982 RID: 31106 RVA: 0x00039C4A File Offset: 0x00037E4A
		public unsafe int ConcealedPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging)) = value;
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06007983 RID: 31107 RVA: 0x0020C060 File Offset: 0x0020A260
		// (set) Token: 0x06007984 RID: 31108 RVA: 0x00039C65 File Offset: 0x00037E65
		public unsafe ProductItemInstance ProductItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x06007985 RID: 31109 RVA: 0x0020C090 File Offset: 0x0020A290
		// (set) Token: 0x06007986 RID: 31110 RVA: 0x00039C84 File Offset: 0x00037E84
		public unsafe FunctionalProduct ProductPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x0020C0C0 File Offset: 0x0020A2C0
		// (set) Token: 0x06007988 RID: 31112 RVA: 0x00039CA3 File Offset: 0x00037EA3
		public unsafe int ProductInHopper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper)) = value;
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x06007989 RID: 31113 RVA: 0x0020C0E8 File Offset: 0x0020A2E8
		// (set) Token: 0x0600798A RID: 31114 RVA: 0x00039CBE File Offset: 0x00037EBE
		public unsafe List<PackagingTool.PackagingInstance> PackagingInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingTool.PackagingInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x0020C118 File Offset: 0x0020A318
		// (set) Token: 0x0600798C RID: 31116 RVA: 0x00039CDD File Offset: 0x00037EDD
		public unsafe List<FunctionalProduct> ProductInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x0020C148 File Offset: 0x0020A348
		// (set) Token: 0x0600798E RID: 31118 RVA: 0x00039CFC File Offset: 0x00037EFC
		public unsafe List<FunctionalPackaging> FinalizedPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalPackaging>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600798F RID: 31119 RVA: 0x0020C178 File Offset: 0x0020A378
		// (set) Token: 0x06007990 RID: 31120 RVA: 0x00039D1B File Offset: 0x00037F1B
		public unsafe float conveyorVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity)) = value;
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x06007991 RID: 31121 RVA: 0x0020C1A0 File Offset: 0x0020A3A0
		// (set) Token: 0x06007992 RID: 31122 RVA: 0x00039D36 File Offset: 0x00037F36
		public unsafe int directionInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput)) = value;
			}
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x0020C1C8 File Offset: 0x0020A3C8
		// (set) Token: 0x06007994 RID: 31124 RVA: 0x00039D51 File Offset: 0x00037F51
		public unsafe Task task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06007995 RID: 31125 RVA: 0x0020C1F8 File Offset: 0x0020A3F8
		// (set) Token: 0x06007996 RID: 31126 RVA: 0x00039D70 File Offset: 0x00037F70
		public unsafe PackagingTool.PackagingInstance finalizeInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x06007997 RID: 31127 RVA: 0x0020C228 File Offset: 0x0020A428
		// (set) Token: 0x06007998 RID: 31128 RVA: 0x00039D8F File Offset: 0x00037F8F
		public unsafe Coroutine finalizeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x0020C258 File Offset: 0x0020A458
		// (set) Token: 0x0600799A RID: 31130 RVA: 0x00039DAE File Offset: 0x00037FAE
		public unsafe bool leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600799B RID: 31131 RVA: 0x0020C280 File Offset: 0x0020A480
		// (set) Token: 0x0600799C RID: 31132 RVA: 0x00039DC9 File Offset: 0x00037FC9
		public unsafe bool rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x0020C2A8 File Offset: 0x0020A4A8
		// (set) Token: 0x0600799E RID: 31134 RVA: 0x00039DE4 File Offset: 0x00037FE4
		public unsafe bool dropDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown)) = value;
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600799F RID: 31135 RVA: 0x0020C2D0 File Offset: 0x0020A4D0
		// (set) Token: 0x060079A0 RID: 31136 RVA: 0x00039DFF File Offset: 0x00037FFF
		public unsafe float timeSinceLastDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop)) = value;
			}
		}

		// Token: 0x0400527C RID: 21116
		private static readonly IntPtr NativeFieldInfoPtr__ReceiveInput_k__BackingField;

		// Token: 0x0400527D RID: 21117
		private static readonly IntPtr NativeFieldInfoPtr_FinalizeRange_Min;

		// Token: 0x0400527E RID: 21118
		private static readonly IntPtr NativeFieldInfoPtr_FinalizeRange_Max;

		// Token: 0x0400527F RID: 21119
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorSpeed;

		// Token: 0x04005280 RID: 21120
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorAcceleration;

		// Token: 0x04005281 RID: 21121
		private static readonly IntPtr NativeFieldInfoPtr_BaggieRadius;

		// Token: 0x04005282 RID: 21122
		private static readonly IntPtr NativeFieldInfoPtr_JarRadius;

		// Token: 0x04005283 RID: 21123
		private static readonly IntPtr NativeFieldInfoPtr_DeployAngle;

		// Token: 0x04005284 RID: 21124
		private static readonly IntPtr NativeFieldInfoPtr_ProductInitialForce;

		// Token: 0x04005285 RID: 21125
		private static readonly IntPtr NativeFieldInfoPtr_ProductRandomTorque;

		// Token: 0x04005286 RID: 21126
		private static readonly IntPtr NativeFieldInfoPtr_KickForce;

		// Token: 0x04005287 RID: 21127
		private static readonly IntPtr NativeFieldInfoPtr_DropCooldown;

		// Token: 0x04005288 RID: 21128
		private static readonly IntPtr NativeFieldInfoPtr_Station;

		// Token: 0x04005289 RID: 21129
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorModel;

		// Token: 0x0400528A RID: 21130
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x0400528B RID: 21131
		private static readonly IntPtr NativeFieldInfoPtr_CapAnim;

		// Token: 0x0400528C RID: 21132
		private static readonly IntPtr NativeFieldInfoPtr_SealAnim;

		// Token: 0x0400528D RID: 21133
		private static readonly IntPtr NativeFieldInfoPtr_KickAnim;

		// Token: 0x0400528E RID: 21134
		private static readonly IntPtr NativeFieldInfoPtr_LeftButton;

		// Token: 0x0400528F RID: 21135
		private static readonly IntPtr NativeFieldInfoPtr_RightButton;

		// Token: 0x04005290 RID: 21136
		private static readonly IntPtr NativeFieldInfoPtr_DropButton;

		// Token: 0x04005291 RID: 21137
		private static readonly IntPtr NativeFieldInfoPtr_PackagingContainer;

		// Token: 0x04005292 RID: 21138
		private static readonly IntPtr NativeFieldInfoPtr_ProductCountText;

		// Token: 0x04005293 RID: 21139
		private static readonly IntPtr NativeFieldInfoPtr_HopperDropPoint;

		// Token: 0x04005294 RID: 21140
		private static readonly IntPtr NativeFieldInfoPtr_BaggieStartPoint;

		// Token: 0x04005295 RID: 21141
		private static readonly IntPtr NativeFieldInfoPtr_JarStartPoint;

		// Token: 0x04005296 RID: 21142
		private static readonly IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x04005297 RID: 21143
		private static readonly IntPtr NativeFieldInfoPtr_KickOrigin;

		// Token: 0x04005298 RID: 21144
		private static readonly IntPtr NativeFieldInfoPtr_HopperInputCollider;

		// Token: 0x04005299 RID: 21145
		private static readonly IntPtr NativeFieldInfoPtr_KickSound;

		// Token: 0x0400529A RID: 21146
		private static readonly IntPtr NativeFieldInfoPtr_MotorSound;

		// Token: 0x0400529B RID: 21147
		private static readonly IntPtr NativeFieldInfoPtr_DropSound;

		// Token: 0x0400529C RID: 21148
		private static readonly IntPtr NativeFieldInfoPtr_PackagingPrefab;

		// Token: 0x0400529D RID: 21149
		private static readonly IntPtr NativeFieldInfoPtr_ConcealedPackaging;

		// Token: 0x0400529E RID: 21150
		private static readonly IntPtr NativeFieldInfoPtr_ProductItem;

		// Token: 0x0400529F RID: 21151
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrefab;

		// Token: 0x040052A0 RID: 21152
		private static readonly IntPtr NativeFieldInfoPtr_ProductInHopper;

		// Token: 0x040052A1 RID: 21153
		private static readonly IntPtr NativeFieldInfoPtr_PackagingInstances;

		// Token: 0x040052A2 RID: 21154
		private static readonly IntPtr NativeFieldInfoPtr_ProductInstances;

		// Token: 0x040052A3 RID: 21155
		private static readonly IntPtr NativeFieldInfoPtr_FinalizedPackaging;

		// Token: 0x040052A4 RID: 21156
		private static readonly IntPtr NativeFieldInfoPtr_conveyorVelocity;

		// Token: 0x040052A5 RID: 21157
		private static readonly IntPtr NativeFieldInfoPtr_directionInput;

		// Token: 0x040052A6 RID: 21158
		private static readonly IntPtr NativeFieldInfoPtr_task;

		// Token: 0x040052A7 RID: 21159
		private static readonly IntPtr NativeFieldInfoPtr_finalizeInstance;

		// Token: 0x040052A8 RID: 21160
		private static readonly IntPtr NativeFieldInfoPtr_finalizeCoroutine;

		// Token: 0x040052A9 RID: 21161
		private static readonly IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x040052AA RID: 21162
		private static readonly IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x040052AB RID: 21163
		private static readonly IntPtr NativeFieldInfoPtr_dropDown;

		// Token: 0x040052AC RID: 21164
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastDrop;

		// Token: 0x040052AD RID: 21165
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0;

		// Token: 0x040052AE RID: 21166
		private static readonly IntPtr NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0;

		// Token: 0x040052AF RID: 21167
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0;

		// Token: 0x040052B0 RID: 21168
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Void_0;

		// Token: 0x040052B1 RID: 21169
		private static readonly IntPtr NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0;

		// Token: 0x040052B2 RID: 21170
		private static readonly IntPtr NativeMethodInfoPtr_UnloadPackaging_Private_Void_0;

		// Token: 0x040052B3 RID: 21171
		private static readonly IntPtr NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0;

		// Token: 0x040052B4 RID: 21172
		private static readonly IntPtr NativeMethodInfoPtr_UnloadProduct_Private_Void_0;

		// Token: 0x040052B5 RID: 21173
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040052B6 RID: 21174
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040052B7 RID: 21175
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreen_Private_Void_0;

		// Token: 0x040052B8 RID: 21176
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConveyor_Private_Void_0;

		// Token: 0x040052B9 RID: 21177
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Private_Void_Single_0;

		// Token: 0x040052BA RID: 21178
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0;

		// Token: 0x040052BB RID: 21179
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalize_Private_Void_0;

		// Token: 0x040052BC RID: 21180
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0;

		// Token: 0x040052BD RID: 21181
		private static readonly IntPtr NativeMethodInfoPtr_DropProduct_Private_Void_0;

		// Token: 0x040052BE RID: 21182
		private static readonly IntPtr NativeMethodInfoPtr_CheckInsertions_Private_Void_0;

		// Token: 0x040052BF RID: 21183
		private static readonly IntPtr NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0;

		// Token: 0x040052C0 RID: 21184
		private static readonly IntPtr NativeMethodInfoPtr_DeployPackaging_Private_Void_0;

		// Token: 0x040052C1 RID: 21185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA8 RID: 2728
		public class PackagingInstance : Il2CppSystem.Object
		{
			// Token: 0x0600D34D RID: 54093 RVA: 0x00327D88 File Offset: 0x00325F88
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingInstance()
			{
				Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr);
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Container");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "ContainerRb");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Packaging");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "AnglePosition");
				PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678507);
				PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678508);
			}

			// Token: 0x0600D34E RID: 54094 RVA: 0x00327E2C File Offset: 0x0032602C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 232744, RefRangeEnd = 232745, XrefRangeStart = 232738, XrefRangeEnd = 232744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangePosition(float angleDelta)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref angleDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D34F RID: 54095 RVA: 0x00327E6C File Offset: 0x0032606C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D350 RID: 54096 RVA: 0x00066DA9 File Offset: 0x00064FA9
			public PackagingInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004189 RID: 16777
			// (get) Token: 0x0600D351 RID: 54097 RVA: 0x00327EA8 File Offset: 0x003260A8
			// (set) Token: 0x0600D352 RID: 54098 RVA: 0x00066DB2 File Offset: 0x00064FB2
			public unsafe Transform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700418A RID: 16778
			// (get) Token: 0x0600D353 RID: 54099 RVA: 0x00327ED8 File Offset: 0x003260D8
			// (set) Token: 0x0600D354 RID: 54100 RVA: 0x00066DD1 File Offset: 0x00064FD1
			public unsafe Rigidbody ContainerRb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700418B RID: 16779
			// (get) Token: 0x0600D355 RID: 54101 RVA: 0x00327F08 File Offset: 0x00326108
			// (set) Token: 0x0600D356 RID: 54102 RVA: 0x00066DF0 File Offset: 0x00064FF0
			public unsafe FunctionalPackaging Packaging
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700418C RID: 16780
			// (get) Token: 0x0600D357 RID: 54103 RVA: 0x00327F38 File Offset: 0x00326138
			// (set) Token: 0x0600D358 RID: 54104 RVA: 0x00066E0F File Offset: 0x0006500F
			public unsafe float AnglePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition)) = value;
				}
			}

			// Token: 0x04008E5F RID: 36447
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04008E60 RID: 36448
			private static readonly IntPtr NativeFieldInfoPtr_ContainerRb;

			// Token: 0x04008E61 RID: 36449
			private static readonly IntPtr NativeFieldInfoPtr_Packaging;

			// Token: 0x04008E62 RID: 36450
			private static readonly IntPtr NativeFieldInfoPtr_AnglePosition;

			// Token: 0x04008E63 RID: 36451
			private static readonly IntPtr NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0;

			// Token: 0x04008E64 RID: 36452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AA9 RID: 2729
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D359 RID: 54105 RVA: 0x00327F60 File Offset: 0x00326160
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr);
				PackagingTool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9");
				PackagingTool.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9__63_0");
				PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678510);
				PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678511);
			}

			// Token: 0x0600D35A RID: 54106 RVA: 0x00327FDC File Offset: 0x003261DC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D35B RID: 54107 RVA: 0x00328018 File Offset: 0x00326218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232745, XrefRangeEnd = 232747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rotate_b__63_0(PackagingTool.PackagingInstance a, PackagingTool.PackagingInstance b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D35C RID: 54108 RVA: 0x00066E2A File Offset: 0x0006502A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700418D RID: 16781
			// (get) Token: 0x0600D35D RID: 54109 RVA: 0x00328078 File Offset: 0x00326278
			// (set) Token: 0x0600D35E RID: 54110 RVA: 0x00066E33 File Offset: 0x00065033
			public unsafe static PackagingTool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700418E RID: 16782
			// (get) Token: 0x0600D35F RID: 54111 RVA: 0x003280A0 File Offset: 0x003262A0
			// (set) Token: 0x0600D360 RID: 54112 RVA: 0x00066E45 File Offset: 0x00065045
			public unsafe static Comparison<PackagingTool.PackagingInstance> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<PackagingTool.PackagingInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E65 RID: 36453
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E66 RID: 36454
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x04008E67 RID: 36455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E68 RID: 36456
			private static readonly IntPtr NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0;
		}

		// Token: 0x02000AAA RID: 2730
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D361 RID: 54113 RVA: 0x003280C8 File Offset: 0x003262C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr);
				PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "instance");
				PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, 100678512);
				PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, 100678513);
			}

			// Token: 0x0600D362 RID: 54114 RVA: 0x00328144 File Offset: 0x00326344
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D363 RID: 54115 RVA: 0x00328180 File Offset: 0x00326380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232784, XrefRangeEnd = 232789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D364 RID: 54116 RVA: 0x00066E57 File Offset: 0x00065057
			public __c__DisplayClass66_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700418F RID: 16783
			// (get) Token: 0x0600D365 RID: 54117 RVA: 0x003281C0 File Offset: 0x003263C0
			// (set) Token: 0x0600D366 RID: 54118 RVA: 0x00066E60 File Offset: 0x00065060
			public unsafe PackagingTool.PackagingInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004190 RID: 16784
			// (get) Token: 0x0600D367 RID: 54119 RVA: 0x003281F0 File Offset: 0x003263F0
			// (set) Token: 0x0600D368 RID: 54120 RVA: 0x00066E7F File Offset: 0x0006507F
			public unsafe PackagingTool __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E69 RID: 36457
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04008E6A RID: 36458
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E6B RID: 36459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E6C RID: 36460
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C63 RID: 3171
			[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass66_0+<<Finalize>g__FinalizeRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E43F RID: 58431 RVA: 0x003586E8 File Offset: 0x003568E8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "<<Finalize>g__FinalizeRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678514);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678515);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678516);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678517);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678518);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678519);
				}

				// Token: 0x0600E440 RID: 58432 RVA: 0x003587C8 File Offset: 0x003569C8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E441 RID: 58433 RVA: 0x00358810 File Offset: 0x00356A10
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E442 RID: 58434 RVA: 0x00358844 File Offset: 0x00356A44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232747, XrefRangeEnd = 232779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046E4 RID: 18148
				// (get) Token: 0x0600E443 RID: 58435 RVA: 0x00358880 File Offset: 0x00356A80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E444 RID: 58436 RVA: 0x003588C0 File Offset: 0x00356AC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232779, XrefRangeEnd = 232784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046E5 RID: 18149
				// (get) Token: 0x0600E445 RID: 58437 RVA: 0x003588F4 File Offset: 0x00356AF4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E446 RID: 58438 RVA: 0x0006F48B File Offset: 0x0006D68B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046E1 RID: 18145
				// (get) Token: 0x0600E447 RID: 58439 RVA: 0x00358934 File Offset: 0x00356B34
				// (set) Token: 0x0600E448 RID: 58440 RVA: 0x0006F494 File Offset: 0x0006D694
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046E2 RID: 18146
				// (get) Token: 0x0600E449 RID: 58441 RVA: 0x0035895C File Offset: 0x00356B5C
				// (set) Token: 0x0600E44A RID: 58442 RVA: 0x0006F4AF File Offset: 0x0006D6AF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046E3 RID: 18147
				// (get) Token: 0x0600E44B RID: 58443 RVA: 0x0035898C File Offset: 0x00356B8C
				// (set) Token: 0x0600E44C RID: 58444 RVA: 0x0006F4CE File Offset: 0x0006D6CE
				public unsafe PackagingTool.__c__DisplayClass66_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098AF RID: 39087
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098B0 RID: 39088
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098B1 RID: 39089
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098B2 RID: 39090
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098B3 RID: 39091
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098B4 RID: 39092
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098B5 RID: 39093
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098B6 RID: 39094
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098B7 RID: 39095
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
