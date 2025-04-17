using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000039 RID: 57
	public class FlockController : MonoBehaviour
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x0007D3A4 File Offset: 0x0007B5A4
		// Note: this type is marked as 'beforefieldinit'.
		static FlockController()
		{
			Il2CppClassPointerStore<FlockController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockController>.NativeClassPtr);
			FlockController.NativeFieldInfoPtr__childPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childPrefab");
			FlockController.NativeFieldInfoPtr__childAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childAmount");
			FlockController.NativeFieldInfoPtr__slowSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_slowSpawn");
			FlockController.NativeFieldInfoPtr__spawnSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphere");
			FlockController.NativeFieldInfoPtr__spawnSphereHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphereHeight");
			FlockController.NativeFieldInfoPtr__spawnSphereDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphereDepth");
			FlockController.NativeFieldInfoPtr__minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minSpeed");
			FlockController.NativeFieldInfoPtr__maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxSpeed");
			FlockController.NativeFieldInfoPtr__minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minScale");
			FlockController.NativeFieldInfoPtr__maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxScale");
			FlockController.NativeFieldInfoPtr__soarFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarFrequency");
			FlockController.NativeFieldInfoPtr__soarAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarAnimation");
			FlockController.NativeFieldInfoPtr__flapAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flapAnimation");
			FlockController.NativeFieldInfoPtr__idleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_idleAnimation");
			FlockController.NativeFieldInfoPtr__diveValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_diveValue");
			FlockController.NativeFieldInfoPtr__diveFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_diveFrequency");
			FlockController.NativeFieldInfoPtr__minDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minDamping");
			FlockController.NativeFieldInfoPtr__maxDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxDamping");
			FlockController.NativeFieldInfoPtr__waypointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_waypointDistance");
			FlockController.NativeFieldInfoPtr__minAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minAnimationSpeed");
			FlockController.NativeFieldInfoPtr__maxAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxAnimationSpeed");
			FlockController.NativeFieldInfoPtr__randomPositionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_randomPositionTimer");
			FlockController.NativeFieldInfoPtr__positionSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphere");
			FlockController.NativeFieldInfoPtr__positionSphereHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphereHeight");
			FlockController.NativeFieldInfoPtr__positionSphereDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphereDepth");
			FlockController.NativeFieldInfoPtr__childTriggerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childTriggerPos");
			FlockController.NativeFieldInfoPtr__forceChildWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_forceChildWaypoints");
			FlockController.NativeFieldInfoPtr__forcedRandomDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_forcedRandomDelay");
			FlockController.NativeFieldInfoPtr__flatFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flatFly");
			FlockController.NativeFieldInfoPtr__flatSoar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flatSoar");
			FlockController.NativeFieldInfoPtr__birdAvoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoid");
			FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidHorizontalForce");
			FlockController.NativeFieldInfoPtr__birdAvoidDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDown");
			FlockController.NativeFieldInfoPtr__birdAvoidUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidUp");
			FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidVerticalForce");
			FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDistanceMax");
			FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDistanceMin");
			FlockController.NativeFieldInfoPtr__soarMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarMaxTime");
			FlockController.NativeFieldInfoPtr__avoidanceMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_avoidanceMask");
			FlockController.NativeFieldInfoPtr__roamers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_roamers");
			FlockController.NativeFieldInfoPtr__posBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_posBuffer");
			FlockController.NativeFieldInfoPtr__updateDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_updateDivisor");
			FlockController.NativeFieldInfoPtr__newDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_newDelta");
			FlockController.NativeFieldInfoPtr__updateCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_updateCounter");
			FlockController.NativeFieldInfoPtr__activeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_activeChildren");
			FlockController.NativeFieldInfoPtr__groupChildToNewTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupChildToNewTransform");
			FlockController.NativeFieldInfoPtr__groupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupTransform");
			FlockController.NativeFieldInfoPtr__groupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupName");
			FlockController.NativeFieldInfoPtr__groupChildToFlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupChildToFlock");
			FlockController.NativeFieldInfoPtr__startPosOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_startPosOffset");
			FlockController.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_thisT");
			FlockController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663680);
			FlockController.NativeMethodInfoPtr_AddChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663681);
			FlockController.NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663682);
			FlockController.NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663683);
			FlockController.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663684);
			FlockController.NativeMethodInfoPtr_InstantiateGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663685);
			FlockController.NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663686);
			FlockController.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663687);
			FlockController.NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663688);
			FlockController.NativeMethodInfoPtr_destroyBirds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663689);
			FlockController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663690);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0007D8AC File Offset: 0x0007BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74132, XrefRangeEnd = 74139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0007D8E0 File Offset: 0x0007BAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74176, RefRangeEnd = 74177, XrefRangeStart = 74139, XrefRangeEnd = 74176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_AddChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0007D920 File Offset: 0x0007BB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74177, XrefRangeEnd = 74178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildToParent(Transform obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0007D964 File Offset: 0x0007BB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74178, XrefRangeEnd = 74190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74190, XrefRangeEnd = 74206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0007D9D8 File Offset: 0x0007BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74206, XrefRangeEnd = 74226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_InstantiateGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0007DA0C File Offset: 0x0007BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74226, XrefRangeEnd = 74239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChildAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0007DA40 File Offset: 0x0007BC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74239, XrefRangeEnd = 74256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0007DA74 File Offset: 0x0007BC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74270, RefRangeEnd = 74271, XrefRangeStart = 74256, XrefRangeEnd = 74270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlockRandomPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0007DAA8 File Offset: 0x0007BCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74271, XrefRangeEnd = 74283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void destroyBirds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_destroyBirds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0007DADC File Offset: 0x0007BCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74283, XrefRangeEnd = 74301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000047DF File Offset: 0x000029DF
		public FlockController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0007DB18 File Offset: 0x0007BD18
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000047E8 File Offset: 0x000029E8
		public unsafe FlockChild _childPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0007DB48 File Offset: 0x0007BD48
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00004807 File Offset: 0x00002A07
		public unsafe int _childAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childAmount)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0007DB70 File Offset: 0x0007BD70
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004822 File Offset: 0x00002A22
		public unsafe bool _slowSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__slowSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__slowSpawn)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0007DB98 File Offset: 0x0007BD98
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000483D File Offset: 0x00002A3D
		public unsafe float _spawnSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphere)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00004858 File Offset: 0x00002A58
		public unsafe float _spawnSphereHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereHeight)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0007DBE8 File Offset: 0x0007BDE8
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00004873 File Offset: 0x00002A73
		public unsafe float _spawnSphereDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereDepth)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0007DC10 File Offset: 0x0007BE10
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0000488E File Offset: 0x00002A8E
		public unsafe float _minSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minSpeed)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0007DC38 File Offset: 0x0007BE38
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x000048A9 File Offset: 0x00002AA9
		public unsafe float _maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxSpeed)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0007DC60 File Offset: 0x0007BE60
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x000048C4 File Offset: 0x00002AC4
		public unsafe float _minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minScale)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0007DC88 File Offset: 0x0007BE88
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x000048DF File Offset: 0x00002ADF
		public unsafe float _maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxScale)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0007DCB0 File Offset: 0x0007BEB0
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x000048FA File Offset: 0x00002AFA
		public unsafe float _soarFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarFrequency)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0007DCD8 File Offset: 0x0007BED8
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00004915 File Offset: 0x00002B15
		public unsafe string _soarAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0007DD00 File Offset: 0x0007BF00
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00004934 File Offset: 0x00002B34
		public unsafe string _flapAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flapAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flapAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0007DD28 File Offset: 0x0007BF28
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00004953 File Offset: 0x00002B53
		public unsafe string _idleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__idleAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__idleAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0007DD50 File Offset: 0x0007BF50
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00004972 File Offset: 0x00002B72
		public unsafe float _diveValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveValue)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0007DD78 File Offset: 0x0007BF78
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0000498D File Offset: 0x00002B8D
		public unsafe float _diveFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveFrequency)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000049A8 File Offset: 0x00002BA8
		public unsafe float _minDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minDamping)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0007DDC8 File Offset: 0x0007BFC8
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x000049C3 File Offset: 0x00002BC3
		public unsafe float _maxDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxDamping)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x000049DE File Offset: 0x00002BDE
		public unsafe float _waypointDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__waypointDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__waypointDistance)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0007DE18 File Offset: 0x0007C018
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x000049F9 File Offset: 0x00002BF9
		public unsafe float _minAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minAnimationSpeed)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0007DE40 File Offset: 0x0007C040
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00004A14 File Offset: 0x00002C14
		public unsafe float _maxAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxAnimationSpeed)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0007DE68 File Offset: 0x0007C068
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00004A2F File Offset: 0x00002C2F
		public unsafe float _randomPositionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__randomPositionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__randomPositionTimer)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0007DE90 File Offset: 0x0007C090
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00004A4A File Offset: 0x00002C4A
		public unsafe float _positionSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphere)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0007DEB8 File Offset: 0x0007C0B8
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00004A65 File Offset: 0x00002C65
		public unsafe float _positionSphereHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereHeight)) = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0007DEE0 File Offset: 0x0007C0E0
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00004A80 File Offset: 0x00002C80
		public unsafe float _positionSphereDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereDepth)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0007DF08 File Offset: 0x0007C108
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00004A9B File Offset: 0x00002C9B
		public unsafe bool _childTriggerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childTriggerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childTriggerPos)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0007DF30 File Offset: 0x0007C130
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00004AB6 File Offset: 0x00002CB6
		public unsafe bool _forceChildWaypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forceChildWaypoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forceChildWaypoints)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0007DF58 File Offset: 0x0007C158
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public unsafe float _forcedRandomDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forcedRandomDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forcedRandomDelay)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0007DF80 File Offset: 0x0007C180
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00004AEC File Offset: 0x00002CEC
		public unsafe bool _flatFly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatFly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatFly)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0007DFA8 File Offset: 0x0007C1A8
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00004B07 File Offset: 0x00002D07
		public unsafe bool _flatSoar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatSoar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatSoar)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0007DFD0 File Offset: 0x0007C1D0
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00004B22 File Offset: 0x00002D22
		public unsafe bool _birdAvoid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoid)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0007DFF8 File Offset: 0x0007C1F8
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00004B3D File Offset: 0x00002D3D
		public unsafe int _birdAvoidHorizontalForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0007E020 File Offset: 0x0007C220
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00004B58 File Offset: 0x00002D58
		public unsafe bool _birdAvoidDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDown)) = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0007E048 File Offset: 0x0007C248
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00004B73 File Offset: 0x00002D73
		public unsafe bool _birdAvoidUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidUp)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0007E070 File Offset: 0x0007C270
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00004B8E File Offset: 0x00002D8E
		public unsafe int _birdAvoidVerticalForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0007E098 File Offset: 0x0007C298
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00004BA9 File Offset: 0x00002DA9
		public unsafe float _birdAvoidDistanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0007E0C0 File Offset: 0x0007C2C0
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00004BC4 File Offset: 0x00002DC4
		public unsafe float _birdAvoidDistanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0007E0E8 File Offset: 0x0007C2E8
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00004BDF File Offset: 0x00002DDF
		public unsafe float _soarMaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarMaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarMaxTime)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0007E110 File Offset: 0x0007C310
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00004BFA File Offset: 0x00002DFA
		public unsafe LayerMask _avoidanceMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__avoidanceMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__avoidanceMask)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0007E138 File Offset: 0x0007C338
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00004C15 File Offset: 0x00002E15
		public unsafe List<FlockChild> _roamers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__roamers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlockChild>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__roamers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0007E168 File Offset: 0x0007C368
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00004C34 File Offset: 0x00002E34
		public unsafe Vector3 _posBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__posBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__posBuffer)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0007E190 File Offset: 0x0007C390
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00004C4F File Offset: 0x00002E4F
		public unsafe int _updateDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateDivisor)) = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0007E1B8 File Offset: 0x0007C3B8
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00004C6A File Offset: 0x00002E6A
		public unsafe float _newDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__newDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__newDelta)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0007E1E0 File Offset: 0x0007C3E0
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00004C85 File Offset: 0x00002E85
		public unsafe int _updateCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateCounter)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0007E208 File Offset: 0x0007C408
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public unsafe float _activeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__activeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__activeChildren)) = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0007E230 File Offset: 0x0007C430
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00004CBB File Offset: 0x00002EBB
		public unsafe bool _groupChildToNewTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToNewTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToNewTransform)) = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0007E258 File Offset: 0x0007C458
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00004CD6 File Offset: 0x00002ED6
		public unsafe Transform _groupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0007E288 File Offset: 0x0007C488
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00004CF5 File Offset: 0x00002EF5
		public unsafe string _groupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0007E2B0 File Offset: 0x0007C4B0
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe bool _groupChildToFlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToFlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToFlock)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0007E2D8 File Offset: 0x0007C4D8
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00004D2F File Offset: 0x00002F2F
		public unsafe Vector3 _startPosOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__startPosOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__startPosOffset)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0007E300 File Offset: 0x0007C500
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00004D4A File Offset: 0x00002F4A
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr__childPrefab;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr__childAmount;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr__slowSpawn;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphere;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphereHeight;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphereDepth;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr__minSpeed;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr__maxSpeed;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr__minScale;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr__maxScale;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr__soarFrequency;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr__soarAnimation;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr__flapAnimation;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr__idleAnimation;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr__diveValue;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr__diveFrequency;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr__minDamping;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr__maxDamping;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr__waypointDistance;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr__minAnimationSpeed;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr__maxAnimationSpeed;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr__randomPositionTimer;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr__positionSphere;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr__positionSphereHeight;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr__positionSphereDepth;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr__childTriggerPos;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr__forceChildWaypoints;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr__forcedRandomDelay;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr__flatFly;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr__flatSoar;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoid;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidHorizontalForce;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDown;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidUp;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidVerticalForce;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDistanceMax;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDistanceMin;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr__soarMaxTime;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr__avoidanceMask;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr__roamers;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr__posBuffer;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr__updateDivisor;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr__newDelta;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr__updateCounter;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr__activeChildren;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr__groupChildToNewTransform;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeFieldInfoPtr__groupTransform;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr__groupName;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr__groupChildToFlock;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr__startPosOffset;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_Int32_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGroup_Public_Void_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_destroyBirds_Public_Void_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
