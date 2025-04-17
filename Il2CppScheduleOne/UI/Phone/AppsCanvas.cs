using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A0 RID: 1696
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		// Token: 0x0600976F RID: 38767 RVA: 0x0026B4B8 File Offset: 0x002696B8
		// Note: this type is marked as 'beforefieldinit'.
		static AppsCanvas()
		{
			Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "AppsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr);
			AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			AppsCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "canvas");
			AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "delayedSetOpenRoutine");
			AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681977);
			AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681978);
			AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681979);
			AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681980);
			AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681981);
			AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681982);
			AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681983);
			AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681984);
			AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681985);
			AppsCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681986);
			AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681987);
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x06009770 RID: 38768 RVA: 0x0026B600 File Offset: 0x00269800
		// (set) Token: 0x06009771 RID: 38769 RVA: 0x0026B63C File Offset: 0x0026983C
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x0026B67C File Offset: 0x0026987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270904, XrefRangeEnd = 270910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0026B6B8 File Offset: 0x002698B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270910, XrefRangeEnd = 270941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0026B704 File Offset: 0x00269904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270941, XrefRangeEnd = 270943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x0026B738 File Offset: 0x00269938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270943, XrefRangeEnd = 270950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x0026B76C File Offset: 0x0026996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270950, XrefRangeEnd = 270955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x0026B7C8 File Offset: 0x002699C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270958, RefRangeEnd = 270959, XrefRangeStart = 270955, XrefRangeEnd = 270958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x0026B808 File Offset: 0x00269A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270959, XrefRangeEnd = 270962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x0026B848 File Offset: 0x00269A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270962, XrefRangeEnd = 270971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x0026B884 File Offset: 0x00269A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270971, XrefRangeEnd = 270974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x00049A5D File Offset: 0x00047C5D
		public AppsCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x0026B8C0 File Offset: 0x00269AC0
		// (set) Token: 0x0600977D RID: 38781 RVA: 0x00049A66 File Offset: 0x00047C66
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600977E RID: 38782 RVA: 0x0026B8E8 File Offset: 0x00269AE8
		// (set) Token: 0x0600977F RID: 38783 RVA: 0x00049A81 File Offset: 0x00047C81
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x06009780 RID: 38784 RVA: 0x0026B918 File Offset: 0x00269B18
		// (set) Token: 0x06009781 RID: 38785 RVA: 0x00049AA0 File Offset: 0x00047CA0
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006606 RID: 26118
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006607 RID: 26119
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006608 RID: 26120
		private static readonly IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x04006609 RID: 26121
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400660A RID: 26122
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400660B RID: 26123
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400660C RID: 26124
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400660D RID: 26125
		private static readonly IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x0400660E RID: 26126
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x0400660F RID: 26127
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04006610 RID: 26128
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006611 RID: 26129
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0;

		// Token: 0x04006612 RID: 26130
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006613 RID: 26131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B66 RID: 2918
		[ObfuscatedName("ScheduleOne.UI.Phone.AppsCanvas+<DelayedSetCanvasActive>d__10")]
		public sealed class _DelayedSetCanvasActive_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DA79 RID: 55929 RVA: 0x0033C6E4 File Offset: 0x0033A8E4
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__10()
			{
				Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<DelayedSetCanvasActive>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>1__state");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>2__current");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "delay");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>4__this");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "active");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681988);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681989);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681990);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681991);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681992);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681993);
			}

			// Token: 0x0600DA7A RID: 55930 RVA: 0x0033C7EC File Offset: 0x0033A9EC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA7B RID: 55931 RVA: 0x0033C834 File Offset: 0x0033AA34
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA7C RID: 55932 RVA: 0x0033C868 File Offset: 0x0033AA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270894, XrefRangeEnd = 270899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043C7 RID: 17351
			// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x0033C8A4 File Offset: 0x0033AAA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA7E RID: 55934 RVA: 0x0033C8E4 File Offset: 0x0033AAE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270899, XrefRangeEnd = 270904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043C8 RID: 17352
			// (get) Token: 0x0600DA7F RID: 55935 RVA: 0x0033C918 File Offset: 0x0033AB18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA80 RID: 55936 RVA: 0x0006A617 File Offset: 0x00068817
			public _DelayedSetCanvasActive_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C2 RID: 17346
			// (get) Token: 0x0600DA81 RID: 55937 RVA: 0x0033C958 File Offset: 0x0033AB58
			// (set) Token: 0x0600DA82 RID: 55938 RVA: 0x0006A620 File Offset: 0x00068820
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043C3 RID: 17347
			// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x0033C980 File Offset: 0x0033AB80
			// (set) Token: 0x0600DA84 RID: 55940 RVA: 0x0006A63B File Offset: 0x0006883B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C4 RID: 17348
			// (get) Token: 0x0600DA85 RID: 55941 RVA: 0x0033C9B0 File Offset: 0x0033ABB0
			// (set) Token: 0x0600DA86 RID: 55942 RVA: 0x0006A65A File Offset: 0x0006885A
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170043C5 RID: 17349
			// (get) Token: 0x0600DA87 RID: 55943 RVA: 0x0033C9D8 File Offset: 0x0033ABD8
			// (set) Token: 0x0600DA88 RID: 55944 RVA: 0x0006A675 File Offset: 0x00068875
			public unsafe AppsCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppsCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C6 RID: 17350
			// (get) Token: 0x0600DA89 RID: 55945 RVA: 0x0033CA08 File Offset: 0x0033AC08
			// (set) Token: 0x0600DA8A RID: 55946 RVA: 0x0006A694 File Offset: 0x00068894
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x040092A3 RID: 37539
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092A4 RID: 37540
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092A5 RID: 37541
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040092A6 RID: 37542
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092A7 RID: 37543
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x040092A8 RID: 37544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092A9 RID: 37545
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092AA RID: 37546
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092AB RID: 37547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092AC RID: 37548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092AD RID: 37549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
