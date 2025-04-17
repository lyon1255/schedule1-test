using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E4 RID: 1252
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x06006E9E RID: 28318 RVA: 0x001E92F4 File Offset: 0x001E74F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPusher()
		{
			Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "PlayerPusher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr);
			PlayerPusher.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "veh");
			PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinSpeedToPush");
			PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushSpeed");
			PlayerPusher.NativeFieldInfoPtr_MinPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinPushForce");
			PlayerPusher.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushForce");
			PlayerPusher.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "collider");
			PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677288);
			PlayerPusher.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677289);
			PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677290);
			PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677291);
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x001E93EC File Offset: 0x001E75EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220149, XrefRangeEnd = 220162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x001E9420 File Offset: 0x001E7620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220162, XrefRangeEnd = 220165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x001E9454 File Offset: 0x001E7654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220165, XrefRangeEnd = 220198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x001E9498 File Offset: 0x001E7698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220198, XrefRangeEnd = 220199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPusher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x00034568 File Offset: 0x00032768
		public PlayerPusher(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x001E94D4 File Offset: 0x001E76D4
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x00034571 File Offset: 0x00032771
		public unsafe LandVehicle veh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x001E9504 File Offset: 0x001E7704
		// (set) Token: 0x06006EA7 RID: 28327 RVA: 0x00034590 File Offset: 0x00032790
		public unsafe float MinSpeedToPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush)) = value;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x001E952C File Offset: 0x001E772C
		// (set) Token: 0x06006EA9 RID: 28329 RVA: 0x000345AB File Offset: 0x000327AB
		public unsafe float MaxPushSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed)) = value;
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06006EAA RID: 28330 RVA: 0x001E9554 File Offset: 0x001E7754
		// (set) Token: 0x06006EAB RID: 28331 RVA: 0x000345C6 File Offset: 0x000327C6
		public unsafe float MinPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce)) = value;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06006EAC RID: 28332 RVA: 0x001E957C File Offset: 0x001E777C
		// (set) Token: 0x06006EAD RID: 28333 RVA: 0x000345E1 File Offset: 0x000327E1
		public unsafe float MaxPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce)) = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06006EAE RID: 28334 RVA: 0x001E95A4 File Offset: 0x001E77A4
		// (set) Token: 0x06006EAF RID: 28335 RVA: 0x000345FC File Offset: 0x000327FC
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BB0 RID: 19376
		private static readonly IntPtr NativeFieldInfoPtr_veh;

		// Token: 0x04004BB1 RID: 19377
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeedToPush;

		// Token: 0x04004BB2 RID: 19378
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushSpeed;

		// Token: 0x04004BB3 RID: 19379
		private static readonly IntPtr NativeFieldInfoPtr_MinPushForce;

		// Token: 0x04004BB4 RID: 19380
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x04004BB5 RID: 19381
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04004BB6 RID: 19382
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004BB7 RID: 19383
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004BB8 RID: 19384
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004BB9 RID: 19385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
