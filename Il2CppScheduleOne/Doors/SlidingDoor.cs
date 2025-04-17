using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000429 RID: 1065
	public class SlidingDoor : MonoBehaviour
	{
		// Token: 0x06005DA9 RID: 23977 RVA: 0x001AFED0 File Offset: 0x001AE0D0
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingDoor()
		{
			Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SlidingDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr);
			SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			SlidingDoor.NativeFieldInfoPtr_DoorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "DoorTransform");
			SlidingDoor.NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "ClosedPosition");
			SlidingDoor.NativeFieldInfoPtr_OpenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "OpenPosition");
			SlidingDoor.NativeFieldInfoPtr_SlideDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "SlideDuration");
			SlidingDoor.NativeFieldInfoPtr_SlideCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "SlideCurve");
			SlidingDoor.NativeFieldInfoPtr_MoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "MoveRoutine");
			SlidingDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675213);
			SlidingDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675214);
			SlidingDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675215);
			SlidingDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675216);
			SlidingDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675217);
			SlidingDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675218);
			SlidingDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100675219);
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06005DAA RID: 23978 RVA: 0x001B0018 File Offset: 0x001AE218
		// (set) Token: 0x06005DAB RID: 23979 RVA: 0x001B0054 File Offset: 0x001AE254
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x001B0094 File Offset: 0x001AE294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195990, XrefRangeEnd = 195991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Opened(EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlidingDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x001B00E0 File Offset: 0x001AE2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195991, XrefRangeEnd = 195992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Closed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlidingDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x001B011C File Offset: 0x001AE31C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196000, RefRangeEnd = 196002, XrefRangeStart = 195992, XrefRangeEnd = 196000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x001B0150 File Offset: 0x001AE350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196002, XrefRangeEnd = 196003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x001B018C File Offset: 0x001AE38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196003, XrefRangeEnd = 196008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x0002C29E File Offset: 0x0002A49E
		public SlidingDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06005DB2 RID: 23986 RVA: 0x001B01CC File Offset: 0x001AE3CC
		// (set) Token: 0x06005DB3 RID: 23987 RVA: 0x0002C2A7 File Offset: 0x0002A4A7
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06005DB4 RID: 23988 RVA: 0x001B01F4 File Offset: 0x001AE3F4
		// (set) Token: 0x06005DB5 RID: 23989 RVA: 0x0002C2C2 File Offset: 0x0002A4C2
		public unsafe Transform DoorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_DoorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_DoorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06005DB6 RID: 23990 RVA: 0x001B0224 File Offset: 0x001AE424
		// (set) Token: 0x06005DB7 RID: 23991 RVA: 0x0002C2E1 File Offset: 0x0002A4E1
		public unsafe Transform ClosedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_ClosedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_ClosedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06005DB8 RID: 23992 RVA: 0x001B0254 File Offset: 0x001AE454
		// (set) Token: 0x06005DB9 RID: 23993 RVA: 0x0002C300 File Offset: 0x0002A500
		public unsafe Transform OpenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_OpenPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_OpenPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06005DBA RID: 23994 RVA: 0x001B0284 File Offset: 0x001AE484
		// (set) Token: 0x06005DBB RID: 23995 RVA: 0x0002C31F File Offset: 0x0002A51F
		public unsafe float SlideDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideDuration)) = value;
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x001B02AC File Offset: 0x001AE4AC
		// (set) Token: 0x06005DBD RID: 23997 RVA: 0x0002C33A File Offset: 0x0002A53A
		public unsafe AnimationCurve SlideCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x001B02DC File Offset: 0x001AE4DC
		// (set) Token: 0x06005DBF RID: 23999 RVA: 0x0002C359 File Offset: 0x0002A559
		public unsafe Coroutine MoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_MoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_MoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004015 RID: 16405
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004016 RID: 16406
		private static readonly IntPtr NativeFieldInfoPtr_DoorTransform;

		// Token: 0x04004017 RID: 16407
		private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

		// Token: 0x04004018 RID: 16408
		private static readonly IntPtr NativeFieldInfoPtr_OpenPosition;

		// Token: 0x04004019 RID: 16409
		private static readonly IntPtr NativeFieldInfoPtr_SlideDuration;

		// Token: 0x0400401A RID: 16410
		private static readonly IntPtr NativeFieldInfoPtr_SlideCurve;

		// Token: 0x0400401B RID: 16411
		private static readonly IntPtr NativeFieldInfoPtr_MoveRoutine;

		// Token: 0x0400401C RID: 16412
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400401D RID: 16413
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400401E RID: 16414
		private static readonly IntPtr NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x0400401F RID: 16415
		private static readonly IntPtr NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0;

		// Token: 0x04004020 RID: 16416
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04004021 RID: 16417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004022 RID: 16418
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009F0 RID: 2544
		[ObfuscatedName("ScheduleOne.Doors.SlidingDoor+<<Move>g__Move|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CDA7 RID: 52647 RVA: 0x00318428 File Offset: 0x00316628
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique()
			{
				Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "<<Move>g__Move|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>1__state");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>2__current");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>4__this");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<start>5__2");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<end>5__3");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<i>5__4");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675220);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675221);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675222);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675223);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675224);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100675225);
			}

			// Token: 0x0600CDA8 RID: 52648 RVA: 0x00318544 File Offset: 0x00316744
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDA9 RID: 52649 RVA: 0x0031858C File Offset: 0x0031678C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDAA RID: 52650 RVA: 0x003185C0 File Offset: 0x003167C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195969, XrefRangeEnd = 195985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0600CDAB RID: 52651 RVA: 0x003185FC File Offset: 0x003167FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CDAC RID: 52652 RVA: 0x0031863C File Offset: 0x0031683C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195985, XrefRangeEnd = 195990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004008 RID: 16392
			// (get) Token: 0x0600CDAD RID: 52653 RVA: 0x00318670 File Offset: 0x00316870
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CDAE RID: 52654 RVA: 0x0006400C File Offset: 0x0006220C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004001 RID: 16385
			// (get) Token: 0x0600CDAF RID: 52655 RVA: 0x003186B0 File Offset: 0x003168B0
			// (set) Token: 0x0600CDB0 RID: 52656 RVA: 0x00064015 File Offset: 0x00062215
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004002 RID: 16386
			// (get) Token: 0x0600CDB1 RID: 52657 RVA: 0x003186D8 File Offset: 0x003168D8
			// (set) Token: 0x0600CDB2 RID: 52658 RVA: 0x00064030 File Offset: 0x00062230
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004003 RID: 16387
			// (get) Token: 0x0600CDB3 RID: 52659 RVA: 0x00318708 File Offset: 0x00316908
			// (set) Token: 0x0600CDB4 RID: 52660 RVA: 0x0006404F File Offset: 0x0006224F
			public unsafe SlidingDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0600CDB5 RID: 52661 RVA: 0x00318738 File Offset: 0x00316938
			// (set) Token: 0x0600CDB6 RID: 52662 RVA: 0x0006406E File Offset: 0x0006226E
			public unsafe Vector3 _start_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0600CDB7 RID: 52663 RVA: 0x00318760 File Offset: 0x00316960
			// (set) Token: 0x0600CDB8 RID: 52664 RVA: 0x00064089 File Offset: 0x00062289
			public unsafe Vector3 _end_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3)) = value;
				}
			}

			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0600CDB9 RID: 52665 RVA: 0x00318788 File Offset: 0x00316988
			// (set) Token: 0x0600CDBA RID: 52666 RVA: 0x000640A4 File Offset: 0x000622A4
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04008AEE RID: 35566
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AEF RID: 35567
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AF0 RID: 35568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AF1 RID: 35569
			private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x04008AF2 RID: 35570
			private static readonly IntPtr NativeFieldInfoPtr__end_5__3;

			// Token: 0x04008AF3 RID: 35571
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04008AF4 RID: 35572
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AF5 RID: 35573
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AF6 RID: 35574
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AF7 RID: 35575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AF8 RID: 35576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AF9 RID: 35577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
