using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000562 RID: 1378
	public class FunctionalBaggie : FunctionalPackaging
	{
		// Token: 0x060078E2 RID: 30946 RVA: 0x0020A250 File Offset: 0x00208450
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalBaggie()
		{
			Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalBaggie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr);
			FunctionalBaggie.NativeFieldInfoPtr_BagMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "BagMeshes");
			FunctionalBaggie.NativeFieldInfoPtr_FunnelCollidersContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "FunnelCollidersContainer");
			FunctionalBaggie.NativeFieldInfoPtr_FullyPackedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "FullyPackedBlocker");
			FunctionalBaggie.NativeFieldInfoPtr_DynamicCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "DynamicCollider");
			FunctionalBaggie.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			FunctionalBaggie.NativeFieldInfoPtr_ClosedDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "ClosedDelta");
			FunctionalBaggie.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678454);
			FunctionalBaggie.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678455);
			FunctionalBaggie.NativeMethodInfoPtr_SetClosed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678456);
			FunctionalBaggie.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678457);
			FunctionalBaggie.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678458);
			FunctionalBaggie.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678459);
			FunctionalBaggie.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678460);
			FunctionalBaggie.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, 100678461);
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x0020A398 File Offset: 0x00208598
		// (set) Token: 0x060078E4 RID: 30948 RVA: 0x0020A3E0 File Offset: 0x002085E0
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x0020A42C File Offset: 0x0020862C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232608, RefRangeEnd = 232609, XrefRangeStart = 232606, XrefRangeEnd = 232608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClosed(float closedDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closedDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.NativeMethodInfoPtr_SetClosed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x0020A46C File Offset: 0x0020866C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232609, XrefRangeEnd = 232610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x0020A4B8 File Offset: 0x002086B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232610, XrefRangeEnd = 232621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0020A4F4 File Offset: 0x002086F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232621, XrefRangeEnd = 232624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalBaggie.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x0020A530 File Offset: 0x00208730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232624, XrefRangeEnd = 232625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalBaggie() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x0020A56C File Offset: 0x0020876C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232625, XrefRangeEnd = 232630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x000395F6 File Offset: 0x000377F6
		public FunctionalBaggie(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x060078EC RID: 30956 RVA: 0x0020A5AC File Offset: 0x002087AC
		// (set) Token: 0x060078ED RID: 30957 RVA: 0x000395FF File Offset: 0x000377FF
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> BagMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_BagMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_BagMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x060078EE RID: 30958 RVA: 0x0020A5DC File Offset: 0x002087DC
		// (set) Token: 0x060078EF RID: 30959 RVA: 0x0003961E File Offset: 0x0003781E
		public unsafe GameObject FunnelCollidersContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FunnelCollidersContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FunnelCollidersContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x060078F0 RID: 30960 RVA: 0x0020A60C File Offset: 0x0020880C
		// (set) Token: 0x060078F1 RID: 30961 RVA: 0x0003963D File Offset: 0x0003783D
		public unsafe GameObject FullyPackedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FullyPackedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_FullyPackedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x060078F2 RID: 30962 RVA: 0x0020A63C File Offset: 0x0020883C
		// (set) Token: 0x060078F3 RID: 30963 RVA: 0x0003965C File Offset: 0x0003785C
		public unsafe Collider DynamicCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_DynamicCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_DynamicCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x060078F4 RID: 30964 RVA: 0x0020A66C File Offset: 0x0020886C
		// (set) Token: 0x060078F5 RID: 30965 RVA: 0x0003967B File Offset: 0x0003787B
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x060078F6 RID: 30966 RVA: 0x0020A694 File Offset: 0x00208894
		// (set) Token: 0x060078F7 RID: 30967 RVA: 0x00039696 File Offset: 0x00037896
		public unsafe float ClosedDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_ClosedDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.NativeFieldInfoPtr_ClosedDelta)) = value;
			}
		}

		// Token: 0x04005251 RID: 21073
		private static readonly IntPtr NativeFieldInfoPtr_BagMeshes;

		// Token: 0x04005252 RID: 21074
		private static readonly IntPtr NativeFieldInfoPtr_FunnelCollidersContainer;

		// Token: 0x04005253 RID: 21075
		private static readonly IntPtr NativeFieldInfoPtr_FullyPackedBlocker;

		// Token: 0x04005254 RID: 21076
		private static readonly IntPtr NativeFieldInfoPtr_DynamicCollider;

		// Token: 0x04005255 RID: 21077
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04005256 RID: 21078
		private static readonly IntPtr NativeFieldInfoPtr_ClosedDelta;

		// Token: 0x04005257 RID: 21079
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04005258 RID: 21080
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04005259 RID: 21081
		private static readonly IntPtr NativeMethodInfoPtr_SetClosed_Public_Void_Single_0;

		// Token: 0x0400525A RID: 21082
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x0400525B RID: 21083
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_Void_0;

		// Token: 0x0400525C RID: 21084
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0;

		// Token: 0x0400525D RID: 21085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400525E RID: 21086
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AA7 RID: 2727
		[ObfuscatedName("ScheduleOne.Packaging.FunctionalBaggie+<<Seal>g__Routine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D33B RID: 54075 RVA: 0x00327A3C File Offset: 0x00325C3C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique()
			{
				Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FunctionalBaggie>.NativeClassPtr, "<<Seal>g__Routine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<>1__state");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<>2__current");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<>4__this");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678462);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678463);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678464);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678465);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678466);
				FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr, 100678467);
			}

			// Token: 0x0600D33C RID: 54076 RVA: 0x00327B44 File Offset: 0x00325D44
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D33D RID: 54077 RVA: 0x00327B8C File Offset: 0x00325D8C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D33E RID: 54078 RVA: 0x00327BC0 File Offset: 0x00325DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232593, XrefRangeEnd = 232601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004187 RID: 16775
			// (get) Token: 0x0600D33F RID: 54079 RVA: 0x00327BFC File Offset: 0x00325DFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D340 RID: 54080 RVA: 0x00327C3C File Offset: 0x00325E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232601, XrefRangeEnd = 232606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004188 RID: 16776
			// (get) Token: 0x0600D341 RID: 54081 RVA: 0x00327C70 File Offset: 0x00325E70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D342 RID: 54082 RVA: 0x00066D11 File Offset: 0x00064F11
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004182 RID: 16770
			// (get) Token: 0x0600D343 RID: 54083 RVA: 0x00327CB0 File Offset: 0x00325EB0
			// (set) Token: 0x0600D344 RID: 54084 RVA: 0x00066D1A File Offset: 0x00064F1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004183 RID: 16771
			// (get) Token: 0x0600D345 RID: 54085 RVA: 0x00327CD8 File Offset: 0x00325ED8
			// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00066D35 File Offset: 0x00064F35
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004184 RID: 16772
			// (get) Token: 0x0600D347 RID: 54087 RVA: 0x00327D08 File Offset: 0x00325F08
			// (set) Token: 0x0600D348 RID: 54088 RVA: 0x00066D54 File Offset: 0x00064F54
			public unsafe FunctionalBaggie __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalBaggie>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004185 RID: 16773
			// (get) Token: 0x0600D349 RID: 54089 RVA: 0x00327D38 File Offset: 0x00325F38
			// (set) Token: 0x0600D34A RID: 54090 RVA: 0x00066D73 File Offset: 0x00064F73
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004186 RID: 16774
			// (get) Token: 0x0600D34B RID: 54091 RVA: 0x00327D60 File Offset: 0x00325F60
			// (set) Token: 0x0600D34C RID: 54092 RVA: 0x00066D8E File Offset: 0x00064F8E
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalBaggie.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFuSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008E54 RID: 36436
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E55 RID: 36437
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E56 RID: 36438
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E57 RID: 36439
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04008E58 RID: 36440
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008E59 RID: 36441
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E5A RID: 36442
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E5B RID: 36443
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E5C RID: 36444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E5D RID: 36445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E5E RID: 36446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
