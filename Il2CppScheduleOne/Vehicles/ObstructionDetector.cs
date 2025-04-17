using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E2 RID: 1250
	public class ObstructionDetector : MonoBehaviour
	{
		// Token: 0x06006E81 RID: 28289 RVA: 0x001E8E7C File Offset: 0x001E707C
		// Note: this type is marked as 'beforefieldinit'.
		static ObstructionDetector()
		{
			Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ObstructionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr);
			ObstructionDetector.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicle");
			ObstructionDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicles");
			ObstructionDetector.NativeFieldInfoPtr_npcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "npcs");
			ObstructionDetector.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "players");
			ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicleObstacles");
			ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "closestObstructionDistance");
			ObstructionDetector.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "range");
			ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677283);
			ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677284);
			ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677285);
			ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677286);
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x001E8F88 File Offset: 0x001E7188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219956, XrefRangeEnd = 219967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x001E8FC4 File Offset: 0x001E71C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219967, XrefRangeEnd = 220059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x001E9000 File Offset: 0x001E7200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220059, XrefRangeEnd = 220120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x001E9044 File Offset: 0x001E7244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220120, XrefRangeEnd = 220149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObstructionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x00034434 File Offset: 0x00032634
		public ObstructionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x001E9080 File Offset: 0x001E7280
		// (set) Token: 0x06006E88 RID: 28296 RVA: 0x0003443D File Offset: 0x0003263D
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x001E90B0 File Offset: 0x001E72B0
		// (set) Token: 0x06006E8A RID: 28298 RVA: 0x0003445C File Offset: 0x0003265C
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06006E8B RID: 28299 RVA: 0x001E90E0 File Offset: 0x001E72E0
		// (set) Token: 0x06006E8C RID: 28300 RVA: 0x0003447B File Offset: 0x0003267B
		public unsafe List<NPC> npcs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x001E9110 File Offset: 0x001E7310
		// (set) Token: 0x06006E8E RID: 28302 RVA: 0x0003449A File Offset: 0x0003269A
		public unsafe List<PlayerMovement> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMovement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06006E8F RID: 28303 RVA: 0x001E9140 File Offset: 0x001E7340
		// (set) Token: 0x06006E90 RID: 28304 RVA: 0x000344B9 File Offset: 0x000326B9
		public unsafe List<VehicleObstacle> vehicleObstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06006E91 RID: 28305 RVA: 0x001E9170 File Offset: 0x001E7370
		// (set) Token: 0x06006E92 RID: 28306 RVA: 0x000344D8 File Offset: 0x000326D8
		public unsafe float closestObstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance)) = value;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06006E93 RID: 28307 RVA: 0x001E9198 File Offset: 0x001E7398
		// (set) Token: 0x06006E94 RID: 28308 RVA: 0x000344F3 File Offset: 0x000326F3
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x04004BA1 RID: 19361
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004BA2 RID: 19362
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x04004BA3 RID: 19363
		private static readonly IntPtr NativeFieldInfoPtr_npcs;

		// Token: 0x04004BA4 RID: 19364
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04004BA5 RID: 19365
		private static readonly IntPtr NativeFieldInfoPtr_vehicleObstacles;

		// Token: 0x04004BA6 RID: 19366
		private static readonly IntPtr NativeFieldInfoPtr_closestObstructionDistance;

		// Token: 0x04004BA7 RID: 19367
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04004BA8 RID: 19368
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BA9 RID: 19369
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004BAA RID: 19370
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004BAB RID: 19371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
