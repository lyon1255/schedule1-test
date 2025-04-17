using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000781 RID: 1921
	public class OceanCollider : MonoBehaviour
	{
		// Token: 0x0600B5D0 RID: 46544 RVA: 0x002D2E54 File Offset: 0x002D1054
		// Note: this type is marked as 'beforefieldinit'.
		static OceanCollider()
		{
			Il2CppClassPointerStore<OceanCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "OceanCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr);
			OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "localPlayerBeingWarped");
			OceanCollider.NativeFieldInfoPtr_warpedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "warpedVehicles");
			OceanCollider.NativeFieldInfoPtr_SplashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "SplashSound");
			OceanCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685644);
			OceanCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685645);
			OceanCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685646);
			OceanCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, 100685647);
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x002D2F10 File Offset: 0x002D1110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310450, XrefRangeEnd = 310520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x002D2F54 File Offset: 0x002D1154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310520, XrefRangeEnd = 310525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x002D2F94 File Offset: 0x002D1194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310525, XrefRangeEnd = 310531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x002D2FE4 File Offset: 0x002D11E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310531, XrefRangeEnd = 310539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OceanCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x000593B0 File Offset: 0x000575B0
		public OceanCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x002D3020 File Offset: 0x002D1220
		// (set) Token: 0x0600B5D7 RID: 46551 RVA: 0x000593B9 File Offset: 0x000575B9
		public unsafe bool localPlayerBeingWarped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_localPlayerBeingWarped)) = value;
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600B5D8 RID: 46552 RVA: 0x002D3048 File Offset: 0x002D1248
		// (set) Token: 0x0600B5D9 RID: 46553 RVA: 0x000593D4 File Offset: 0x000575D4
		public unsafe List<LandVehicle> warpedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_warpedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_warpedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600B5DA RID: 46554 RVA: 0x002D3078 File Offset: 0x002D1278
		// (set) Token: 0x0600B5DB RID: 46555 RVA: 0x000593F3 File Offset: 0x000575F3
		public unsafe AudioSourceController SplashSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_SplashSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider.NativeFieldInfoPtr_SplashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A81 RID: 31361
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerBeingWarped;

		// Token: 0x04007A82 RID: 31362
		private static readonly IntPtr NativeFieldInfoPtr_warpedVehicles;

		// Token: 0x04007A83 RID: 31363
		private static readonly IntPtr NativeFieldInfoPtr_SplashSound;

		// Token: 0x04007A84 RID: 31364
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04007A85 RID: 31365
		private static readonly IntPtr NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0;

		// Token: 0x04007A86 RID: 31366
		private static readonly IntPtr NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0;

		// Token: 0x04007A87 RID: 31367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFF RID: 3071
		[ObfuscatedName("ScheduleOne.Map.OceanCollider+<WarpPlayer>d__4")]
		public sealed class _WarpPlayer_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600DFE5 RID: 57317 RVA: 0x0034BB64 File Offset: 0x00349D64
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpPlayer_d__4()
			{
				Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "<WarpPlayer>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr);
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>1__state");
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>2__current");
				OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, "<>4__this");
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685648);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685649);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685650);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685651);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685652);
				OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr, 100685653);
			}

			// Token: 0x0600DFE6 RID: 57318 RVA: 0x0034BC44 File Offset: 0x00349E44
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpPlayer_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider._WarpPlayer_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE7 RID: 57319 RVA: 0x0034BC8C File Offset: 0x00349E8C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFE8 RID: 57320 RVA: 0x0034BCC0 File Offset: 0x00349EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310392, XrefRangeEnd = 310398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004562 RID: 17762
			// (get) Token: 0x0600DFE9 RID: 57321 RVA: 0x0034BCFC File Offset: 0x00349EFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFEA RID: 57322 RVA: 0x0034BD3C File Offset: 0x00349F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310398, XrefRangeEnd = 310403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004563 RID: 17763
			// (get) Token: 0x0600DFEB RID: 57323 RVA: 0x0034BD70 File Offset: 0x00349F70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpPlayer_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFEC RID: 57324 RVA: 0x0006D2A9 File Offset: 0x0006B4A9
			public _WarpPlayer_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455F RID: 17759
			// (get) Token: 0x0600DFED RID: 57325 RVA: 0x0034BDB0 File Offset: 0x00349FB0
			// (set) Token: 0x0600DFEE RID: 57326 RVA: 0x0006D2B2 File Offset: 0x0006B4B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004560 RID: 17760
			// (get) Token: 0x0600DFEF RID: 57327 RVA: 0x0034BDD8 File Offset: 0x00349FD8
			// (set) Token: 0x0600DFF0 RID: 57328 RVA: 0x0006D2CD File Offset: 0x0006B4CD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004561 RID: 17761
			// (get) Token: 0x0600DFF1 RID: 57329 RVA: 0x0034BE08 File Offset: 0x0034A008
			// (set) Token: 0x0600DFF2 RID: 57330 RVA: 0x0006D2EC File Offset: 0x0006B4EC
			public unsafe OceanCollider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OceanCollider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpPlayer_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095EE RID: 38382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095EF RID: 38383
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095F0 RID: 38384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095F1 RID: 38385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095F2 RID: 38386
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095F3 RID: 38387
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095F4 RID: 38388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095F5 RID: 38389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095F6 RID: 38390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C00 RID: 3072
		[ObfuscatedName("ScheduleOne.Map.OceanCollider+<WarpVehicle>d__5")]
		public sealed class _WarpVehicle_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600DFF3 RID: 57331 RVA: 0x0034BE38 File Offset: 0x0034A038
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpVehicle_d__5()
			{
				Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OceanCollider>.NativeClassPtr, "<WarpVehicle>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr);
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>1__state");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>2__current");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "veh");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<>4__this");
				OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, "<faded>5__2");
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685654);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685655);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685656);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685657);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685658);
				OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr, 100685659);
			}

			// Token: 0x0600DFF4 RID: 57332 RVA: 0x0034BF40 File Offset: 0x0034A140
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpVehicle_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OceanCollider._WarpVehicle_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF5 RID: 57333 RVA: 0x0034BF88 File Offset: 0x0034A188
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFF6 RID: 57334 RVA: 0x0034BFBC File Offset: 0x0034A1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310403, XrefRangeEnd = 310445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004569 RID: 17769
			// (get) Token: 0x0600DFF7 RID: 57335 RVA: 0x0034BFF8 File Offset: 0x0034A1F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFF8 RID: 57336 RVA: 0x0034C038 File Offset: 0x0034A238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310445, XrefRangeEnd = 310450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700456A RID: 17770
			// (get) Token: 0x0600DFF9 RID: 57337 RVA: 0x0034C06C File Offset: 0x0034A26C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OceanCollider._WarpVehicle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DFFA RID: 57338 RVA: 0x0006D30B File Offset: 0x0006B50B
			public _WarpVehicle_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004564 RID: 17764
			// (get) Token: 0x0600DFFB RID: 57339 RVA: 0x0034C0AC File Offset: 0x0034A2AC
			// (set) Token: 0x0600DFFC RID: 57340 RVA: 0x0006D314 File Offset: 0x0006B514
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004565 RID: 17765
			// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x0034C0D4 File Offset: 0x0034A2D4
			// (set) Token: 0x0600DFFE RID: 57342 RVA: 0x0006D32F File Offset: 0x0006B52F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004566 RID: 17766
			// (get) Token: 0x0600DFFF RID: 57343 RVA: 0x0034C104 File Offset: 0x0034A304
			// (set) Token: 0x0600E000 RID: 57344 RVA: 0x0006D34E File Offset: 0x0006B54E
			public unsafe LandVehicle veh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004567 RID: 17767
			// (get) Token: 0x0600E001 RID: 57345 RVA: 0x0034C134 File Offset: 0x0034A334
			// (set) Token: 0x0600E002 RID: 57346 RVA: 0x0006D36D File Offset: 0x0006B56D
			public unsafe OceanCollider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OceanCollider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004568 RID: 17768
			// (get) Token: 0x0600E003 RID: 57347 RVA: 0x0034C164 File Offset: 0x0034A364
			// (set) Token: 0x0600E004 RID: 57348 RVA: 0x0006D38C File Offset: 0x0006B58C
			public unsafe bool _faded_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OceanCollider._WarpVehicle_d__5.NativeFieldInfoPtr__faded_5__2)) = value;
				}
			}

			// Token: 0x040095F7 RID: 38391
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095F8 RID: 38392
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095F9 RID: 38393
			private static readonly IntPtr NativeFieldInfoPtr_veh;

			// Token: 0x040095FA RID: 38394
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095FB RID: 38395
			private static readonly IntPtr NativeFieldInfoPtr__faded_5__2;

			// Token: 0x040095FC RID: 38396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095FD RID: 38397
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095FE RID: 38398
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095FF RID: 38399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009600 RID: 38400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009601 RID: 38401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
