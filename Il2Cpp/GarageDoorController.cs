using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002C RID: 44
	public class GarageDoorController : MonoBehaviour
	{
		// Token: 0x0600032E RID: 814 RVA: 0x0007A3B8 File Offset: 0x000785B8
		// Note: this type is marked as 'beforefieldinit'.
		static GarageDoorController()
		{
			Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GarageDoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr);
			GarageDoorController.NativeFieldInfoPtr_doorStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "doorStatus");
			GarageDoorController.NativeFieldInfoPtr_garageDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "garageDoor");
			GarageDoorController.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "targetRotation");
			GarageDoorController.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, 100663599);
			GarageDoorController.NativeMethodInfoPtr_Rotate_Private_IEnumerator_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, 100663600);
			GarageDoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, 100663601);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0007A460 File Offset: 0x00078660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73251, XrefRangeEnd = 73265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0007A4A4 File Offset: 0x000786A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73270, RefRangeEnd = 73272, XrefRangeStart = 73265, XrefRangeEnd = 73270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Rotate(Vector3 axis, float angle, float duration = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController.NativeMethodInfoPtr_Rotate_Private_IEnumerator_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0007A50C File Offset: 0x0007870C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73272, XrefRangeEnd = 73273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GarageDoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00003C82 File Offset: 0x00001E82
		public GarageDoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0007A548 File Offset: 0x00078748
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00003C8B File Offset: 0x00001E8B
		public unsafe GarageDoorStatus doorStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_doorStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GarageDoorStatus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_doorStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0007A578 File Offset: 0x00078778
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00003CAA File Offset: 0x00001EAA
		public unsafe Transform garageDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_garageDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_garageDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0007A5A8 File Offset: 0x000787A8
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00003CC9 File Offset: 0x00001EC9
		public unsafe Quaternion targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_doorStatus;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_garageDoor;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Private_IEnumerator_Vector3_Single_Single_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B1 RID: 1969
		[ObfuscatedName("GarageDoorController+<Rotate>d__4")]
		public sealed class _Rotate_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600B995 RID: 47509 RVA: 0x002E0FF4 File Offset: 0x002DF1F4
			// Note: this type is marked as 'beforefieldinit'.
			static _Rotate_d__4()
			{
				Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GarageDoorController>.NativeClassPtr, "<Rotate>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr);
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<>1__state");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<>2__current");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<>4__this");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "axis");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "angle");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "duration");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__from_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<from>5__2");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__to_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<to>5__3");
				GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__elapsed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, "<elapsed>5__4");
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663602);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663603);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663604);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663605);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663606);
				GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr, 100663607);
			}

			// Token: 0x0600B996 RID: 47510 RVA: 0x002E114C File Offset: 0x002DF34C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Rotate_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageDoorController._Rotate_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B997 RID: 47511 RVA: 0x002E1194 File Offset: 0x002DF394
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B998 RID: 47512 RVA: 0x002E11C8 File Offset: 0x002DF3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73236, XrefRangeEnd = 73246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003948 RID: 14664
			// (get) Token: 0x0600B999 RID: 47513 RVA: 0x002E1204 File Offset: 0x002DF404
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B99A RID: 47514 RVA: 0x002E1244 File Offset: 0x002DF444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73246, XrefRangeEnd = 73251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003949 RID: 14665
			// (get) Token: 0x0600B99B RID: 47515 RVA: 0x002E1278 File Offset: 0x002DF478
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GarageDoorController._Rotate_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B99C RID: 47516 RVA: 0x0005AB87 File Offset: 0x00058D87
			public _Rotate_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700393F RID: 14655
			// (get) Token: 0x0600B99D RID: 47517 RVA: 0x002E12B8 File Offset: 0x002DF4B8
			// (set) Token: 0x0600B99E RID: 47518 RVA: 0x0005AB90 File Offset: 0x00058D90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003940 RID: 14656
			// (get) Token: 0x0600B99F RID: 47519 RVA: 0x002E12E0 File Offset: 0x002DF4E0
			// (set) Token: 0x0600B9A0 RID: 47520 RVA: 0x0005ABAB File Offset: 0x00058DAB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003941 RID: 14657
			// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x002E1310 File Offset: 0x002DF510
			// (set) Token: 0x0600B9A2 RID: 47522 RVA: 0x0005ABCA File Offset: 0x00058DCA
			public unsafe GarageDoorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GarageDoorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003942 RID: 14658
			// (get) Token: 0x0600B9A3 RID: 47523 RVA: 0x002E1340 File Offset: 0x002DF540
			// (set) Token: 0x0600B9A4 RID: 47524 RVA: 0x0005ABE9 File Offset: 0x00058DE9
			public unsafe Vector3 axis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_axis);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_axis)) = value;
				}
			}

			// Token: 0x17003943 RID: 14659
			// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x002E1368 File Offset: 0x002DF568
			// (set) Token: 0x0600B9A6 RID: 47526 RVA: 0x0005AC04 File Offset: 0x00058E04
			public unsafe float angle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_angle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_angle)) = value;
				}
			}

			// Token: 0x17003944 RID: 14660
			// (get) Token: 0x0600B9A7 RID: 47527 RVA: 0x002E1390 File Offset: 0x002DF590
			// (set) Token: 0x0600B9A8 RID: 47528 RVA: 0x0005AC1F File Offset: 0x00058E1F
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17003945 RID: 14661
			// (get) Token: 0x0600B9A9 RID: 47529 RVA: 0x002E13B8 File Offset: 0x002DF5B8
			// (set) Token: 0x0600B9AA RID: 47530 RVA: 0x0005AC3A File Offset: 0x00058E3A
			public unsafe Quaternion _from_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__from_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__from_5__2)) = value;
				}
			}

			// Token: 0x17003946 RID: 14662
			// (get) Token: 0x0600B9AB RID: 47531 RVA: 0x002E13E0 File Offset: 0x002DF5E0
			// (set) Token: 0x0600B9AC RID: 47532 RVA: 0x0005AC55 File Offset: 0x00058E55
			public unsafe Quaternion _to_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__to_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__to_5__3)) = value;
				}
			}

			// Token: 0x17003947 RID: 14663
			// (get) Token: 0x0600B9AD RID: 47533 RVA: 0x002E1408 File Offset: 0x002DF608
			// (set) Token: 0x0600B9AE RID: 47534 RVA: 0x0005AC70 File Offset: 0x00058E70
			public unsafe float _elapsed_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__elapsed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GarageDoorController._Rotate_d__4.NativeFieldInfoPtr__elapsed_5__4)) = value;
				}
			}

			// Token: 0x04007D2F RID: 32047
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D30 RID: 32048
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D31 RID: 32049
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D32 RID: 32050
			private static readonly IntPtr NativeFieldInfoPtr_axis;

			// Token: 0x04007D33 RID: 32051
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x04007D34 RID: 32052
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04007D35 RID: 32053
			private static readonly IntPtr NativeFieldInfoPtr__from_5__2;

			// Token: 0x04007D36 RID: 32054
			private static readonly IntPtr NativeFieldInfoPtr__to_5__3;

			// Token: 0x04007D37 RID: 32055
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__4;

			// Token: 0x04007D38 RID: 32056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D39 RID: 32057
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D3A RID: 32058
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D3B RID: 32059
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D3C RID: 32060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D3D RID: 32061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
