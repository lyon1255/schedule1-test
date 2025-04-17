using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001C RID: 28
	public class TrailerCharacterController : MonoBehaviour
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00075DE0 File Offset: 0x00073FE0
		// Note: this type is marked as 'beforefieldinit'.
		static TrailerCharacterController()
		{
			Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrailerCharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr);
			TrailerCharacterController.NativeFieldInfoPtr_StartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, "StartPos");
			TrailerCharacterController.NativeFieldInfoPtr_EndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, "EndPos");
			TrailerCharacterController.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, "Character");
			TrailerCharacterController.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, "WalkSpeed");
			TrailerCharacterController.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, "routine");
			TrailerCharacterController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, 100663454);
			TrailerCharacterController.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, 100663455);
			TrailerCharacterController.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, 100663456);
			TrailerCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, 100663457);
			TrailerCharacterController.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, 100663458);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00075ED8 File Offset: 0x000740D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72228, XrefRangeEnd = 72241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00075F0C File Offset: 0x0007410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72241, XrefRangeEnd = 72250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00075F40 File Offset: 0x00074140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72250, XrefRangeEnd = 72252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00075F74 File Offset: 0x00074174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72252, XrefRangeEnd = 72253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailerCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00075FB0 File Offset: 0x000741B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72253, XrefRangeEnd = 72258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002E91 File Offset: 0x00001091
		public TrailerCharacterController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00075FF0 File Offset: 0x000741F0
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002E9A File Offset: 0x0000109A
		public unsafe Transform StartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_StartPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_StartPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00076020 File Offset: 0x00074220
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002EB9 File Offset: 0x000010B9
		public unsafe Transform EndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_EndPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_EndPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00076050 File Offset: 0x00074250
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002ED8 File Offset: 0x000010D8
		public unsafe Transform Character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_Character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_Character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00076080 File Offset: 0x00074280
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002EF7 File Offset: 0x000010F7
		public unsafe float WalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_WalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_WalkSpeed)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000760A8 File Offset: 0x000742A8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002F12 File Offset: 0x00001112
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_StartPos;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_EndPos;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020007AA RID: 1962
		[ObfuscatedName("TrailerCharacterController+<<Play>g__Routine|6_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600B951 RID: 47441 RVA: 0x002E034C File Offset: 0x002DE54C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique()
			{
				Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrailerCharacterController>.NativeClassPtr, "<<Play>g__Routine|6_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr);
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, "<>1__state");
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, "<>2__current");
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, "<>4__this");
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, "<t>5__3");
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, 100663459);
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, 100663460);
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, 100663461);
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, 100663462);
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, 100663463);
				TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr, 100663464);
			}

			// Token: 0x0600B952 RID: 47442 RVA: 0x002E0454 File Offset: 0x002DE654
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B953 RID: 47443 RVA: 0x002E049C File Offset: 0x002DE69C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B954 RID: 47444 RVA: 0x002E04D0 File Offset: 0x002DE6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72197, XrefRangeEnd = 72223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003935 RID: 14645
			// (get) Token: 0x0600B955 RID: 47445 RVA: 0x002E050C File Offset: 0x002DE70C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B956 RID: 47446 RVA: 0x002E054C File Offset: 0x002DE74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72223, XrefRangeEnd = 72228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003936 RID: 14646
			// (get) Token: 0x0600B957 RID: 47447 RVA: 0x002E0580 File Offset: 0x002DE780
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B958 RID: 47448 RVA: 0x0005A995 File Offset: 0x00058B95
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003930 RID: 14640
			// (get) Token: 0x0600B959 RID: 47449 RVA: 0x002E05C0 File Offset: 0x002DE7C0
			// (set) Token: 0x0600B95A RID: 47450 RVA: 0x0005A99E File Offset: 0x00058B9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003931 RID: 14641
			// (get) Token: 0x0600B95B RID: 47451 RVA: 0x002E05E8 File Offset: 0x002DE7E8
			// (set) Token: 0x0600B95C RID: 47452 RVA: 0x0005A9B9 File Offset: 0x00058BB9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003932 RID: 14642
			// (get) Token: 0x0600B95D RID: 47453 RVA: 0x002E0618 File Offset: 0x002DE818
			// (set) Token: 0x0600B95E RID: 47454 RVA: 0x0005A9D8 File Offset: 0x00058BD8
			public unsafe TrailerCharacterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailerCharacterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003933 RID: 14643
			// (get) Token: 0x0600B95F RID: 47455 RVA: 0x002E0648 File Offset: 0x002DE848
			// (set) Token: 0x0600B960 RID: 47456 RVA: 0x0005A9F7 File Offset: 0x00058BF7
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17003934 RID: 14644
			// (get) Token: 0x0600B961 RID: 47457 RVA: 0x002E0670 File Offset: 0x002DE870
			// (set) Token: 0x0600B962 RID: 47458 RVA: 0x0005AA12 File Offset: 0x00058C12
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerCharacterController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiSiObObUnique.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x04007D0C RID: 32012
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D0D RID: 32013
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D0E RID: 32014
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D0F RID: 32015
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04007D10 RID: 32016
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x04007D11 RID: 32017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D12 RID: 32018
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D13 RID: 32019
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D14 RID: 32020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D15 RID: 32021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D16 RID: 32022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
