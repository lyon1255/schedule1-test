using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046C RID: 1132
	public class VehicleDetector : MonoBehaviour
	{
		// Token: 0x060061FB RID: 25083 RVA: 0x001BE2A0 File Offset: 0x001BC4A0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleDetector()
		{
			Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VehicleDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr);
			VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			VehicleDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "vehicles");
			VehicleDetector.NativeFieldInfoPtr_closestVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "closestVehicle");
			VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			VehicleDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "ignoreExit");
			VehicleDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "detectionColliders");
			VehicleDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "collidersEnabled");
			VehicleDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675739);
			VehicleDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675740);
			VehicleDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675741);
			VehicleDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675742);
			VehicleDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675743);
			VehicleDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675744);
			VehicleDetector.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675745);
			VehicleDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675746);
			VehicleDetector.NativeMethodInfoPtr_SortVehicles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675747);
			VehicleDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675748);
			VehicleDetector.NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675749);
			VehicleDetector.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675750);
			VehicleDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675751);
			VehicleDetector.NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675752);
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x060061FC RID: 25084 RVA: 0x001BE474 File Offset: 0x001BC674
		// (set) Token: 0x060061FD RID: 25085 RVA: 0x001BE4B0 File Offset: 0x001BC6B0
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x001BE4F0 File Offset: 0x001BC6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201504, XrefRangeEnd = 201521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x001BE524 File Offset: 0x001BC724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201521, XrefRangeEnd = 201539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x001BE558 File Offset: 0x001BC758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201539, XrefRangeEnd = 201557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x001BE58C File Offset: 0x001BC78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201557, XrefRangeEnd = 201574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x001BE5D0 File Offset: 0x001BC7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201574, XrefRangeEnd = 201592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x001BE604 File Offset: 0x001BC804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201592, XrefRangeEnd = 201609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x001BE648 File Offset: 0x001BC848
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 201625, RefRangeEnd = 201629, XrefRangeStart = 201609, XrefRangeEnd = 201625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortVehicles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_SortVehicles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x001BE67C File Offset: 0x001BC87C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201636, RefRangeEnd = 201638, XrefRangeStart = 201629, XrefRangeEnd = 201636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x001BE6BC File Offset: 0x001BC8BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201643, RefRangeEnd = 201645, XrefRangeStart = 201638, XrefRangeEnd = 201643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyVehiclesOccupied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x001BE6F8 File Offset: 0x001BC8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201645, XrefRangeEnd = 201649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x001BE72C File Offset: 0x001BC92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201649, XrefRangeEnd = 201657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x001BE768 File Offset: 0x001BC968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201657, XrefRangeEnd = 201664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SortVehicles_b__16_0(LandVehicle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x0002E4AF File Offset: 0x0002C6AF
		public VehicleDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x001BE7B8 File Offset: 0x001BC9B8
		// (set) Token: 0x0600620C RID: 25100 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x001BE7D4 File Offset: 0x001BC9D4
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x0002E4C6 File Offset: 0x0002C6C6
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x0600620F RID: 25103 RVA: 0x001BE804 File Offset: 0x001BCA04
		// (set) Token: 0x06006210 RID: 25104 RVA: 0x0002E4E5 File Offset: 0x0002C6E5
		public unsafe LandVehicle closestVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_closestVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_closestVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x001BE834 File Offset: 0x001BCA34
		// (set) Token: 0x06006212 RID: 25106 RVA: 0x0002E504 File Offset: 0x0002C704
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x001BE85C File Offset: 0x001BCA5C
		// (set) Token: 0x06006214 RID: 25108 RVA: 0x0002E51F File Offset: 0x0002C71F
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x001BE884 File Offset: 0x001BCA84
		// (set) Token: 0x06006216 RID: 25110 RVA: 0x0002E53A File Offset: 0x0002C73A
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x001BE8B4 File Offset: 0x001BCAB4
		// (set) Token: 0x06006218 RID: 25112 RVA: 0x0002E559 File Offset: 0x0002C759
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x040042D0 RID: 17104
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x040042D1 RID: 17105
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x040042D2 RID: 17106
		private static readonly IntPtr NativeFieldInfoPtr_closestVehicle;

		// Token: 0x040042D3 RID: 17107
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x040042D4 RID: 17108
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x040042D5 RID: 17109
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x040042D6 RID: 17110
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x040042D7 RID: 17111
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x040042D8 RID: 17112
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x040042D9 RID: 17113
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040042DA RID: 17114
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042DB RID: 17115
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040042DC RID: 17116
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x040042DD RID: 17117
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040042DE RID: 17118
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x040042DF RID: 17119
		private static readonly IntPtr NativeMethodInfoPtr_SortVehicles_Private_Void_0;

		// Token: 0x040042E0 RID: 17120
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x040042E1 RID: 17121
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0;

		// Token: 0x040042E2 RID: 17122
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040042E3 RID: 17123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040042E4 RID: 17124
		private static readonly IntPtr NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0;
	}
}
