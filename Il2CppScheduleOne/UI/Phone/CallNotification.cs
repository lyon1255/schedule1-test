using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A2 RID: 1698
	public class CallNotification : Singleton<CallNotification>
	{
		// Token: 0x060097BB RID: 38843 RVA: 0x0026C400 File Offset: 0x0026A600
		// Note: this type is marked as 'beforefieldinit'.
		static CallNotification()
		{
			Il2CppClassPointerStore<CallNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification>.NativeClassPtr);
			CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "TIME_PER_CHAR");
			CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallNotification.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "Container");
			CallNotification.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "ProfilePicture");
			CallNotification.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "Group");
			CallNotification.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "slideRoutine");
			CallNotification.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682019);
			CallNotification.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682020);
			CallNotification.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682021);
			CallNotification.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682022);
			CallNotification.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682023);
			CallNotification.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682024);
			CallNotification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682025);
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x060097BC RID: 38844 RVA: 0x0026C548 File Offset: 0x0026A748
		// (set) Token: 0x060097BD RID: 38845 RVA: 0x0026C588 File Offset: 0x0026A788
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x060097BE RID: 38846 RVA: 0x0026C5CC File Offset: 0x0026A7CC
		// (set) Token: 0x060097BF RID: 38847 RVA: 0x0026C608 File Offset: 0x0026A808
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x0026C648 File Offset: 0x0026A848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271317, XrefRangeEnd = 271325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallNotification.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x0026C684 File Offset: 0x0026A884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271325, XrefRangeEnd = 271340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool visible, CallerID caller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x0026C6D4 File Offset: 0x0026A8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271340, XrefRangeEnd = 271343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallNotification() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x00049CF4 File Offset: 0x00047EF4
		public CallNotification(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x060097C4 RID: 38852 RVA: 0x0026C710 File Offset: 0x0026A910
		// (set) Token: 0x060097C5 RID: 38853 RVA: 0x00049CFD File Offset: 0x00047EFD
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x060097C6 RID: 38854 RVA: 0x0026C72C File Offset: 0x0026A92C
		// (set) Token: 0x060097C7 RID: 38855 RVA: 0x00049D0B File Offset: 0x00047F0B
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x060097C8 RID: 38856 RVA: 0x0026C75C File Offset: 0x0026A95C
		// (set) Token: 0x060097C9 RID: 38857 RVA: 0x00049D2A File Offset: 0x00047F2A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x060097CA RID: 38858 RVA: 0x0026C784 File Offset: 0x0026A984
		// (set) Token: 0x060097CB RID: 38859 RVA: 0x00049D45 File Offset: 0x00047F45
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x0026C7B4 File Offset: 0x0026A9B4
		// (set) Token: 0x060097CD RID: 38861 RVA: 0x00049D64 File Offset: 0x00047F64
		public unsafe Image ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x060097CE RID: 38862 RVA: 0x0026C7E4 File Offset: 0x0026A9E4
		// (set) Token: 0x060097CF RID: 38863 RVA: 0x00049D83 File Offset: 0x00047F83
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x060097D0 RID: 38864 RVA: 0x0026C814 File Offset: 0x0026AA14
		// (set) Token: 0x060097D1 RID: 38865 RVA: 0x00049DA2 File Offset: 0x00047FA2
		public unsafe Coroutine slideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_slideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006638 RID: 26168
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x04006639 RID: 26169
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x0400663A RID: 26170
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400663B RID: 26171
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400663C RID: 26172
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x0400663D RID: 26173
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x0400663E RID: 26174
		private static readonly IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x0400663F RID: 26175
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x04006640 RID: 26176
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04006641 RID: 26177
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006642 RID: 26178
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006643 RID: 26179
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006644 RID: 26180
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0;

		// Token: 0x04006645 RID: 26181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B68 RID: 2920
		[ObfuscatedName("ScheduleOne.UI.Phone.CallNotification+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA95 RID: 55957 RVA: 0x0033CBBC File Offset: 0x0033ADBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr);
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "visible");
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "caller");
				CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, 100682026);
				CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, 100682027);
			}

			// Token: 0x0600DA96 RID: 55958 RVA: 0x0033CC4C File Offset: 0x0033AE4C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA97 RID: 55959 RVA: 0x0033CC88 File Offset: 0x0033AE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271312, XrefRangeEnd = 271317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DA98 RID: 55960 RVA: 0x0006A70D File Offset: 0x0006890D
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043CC RID: 17356
			// (get) Token: 0x0600DA99 RID: 55961 RVA: 0x0033CCC8 File Offset: 0x0033AEC8
			// (set) Token: 0x0600DA9A RID: 55962 RVA: 0x0006A716 File Offset: 0x00068916
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x170043CD RID: 17357
			// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x0033CCF0 File Offset: 0x0033AEF0
			// (set) Token: 0x0600DA9C RID: 55964 RVA: 0x0006A731 File Offset: 0x00068931
			public unsafe CallNotification __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallNotification>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CE RID: 17358
			// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x0033CD20 File Offset: 0x0033AF20
			// (set) Token: 0x0600DA9E RID: 55966 RVA: 0x0006A750 File Offset: 0x00068950
			public unsafe CallerID caller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092B3 RID: 37555
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x040092B4 RID: 37556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092B5 RID: 37557
			private static readonly IntPtr NativeFieldInfoPtr_caller;

			// Token: 0x040092B6 RID: 37558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092B7 RID: 37559
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7A RID: 3194
			[ObfuscatedName("ScheduleOne.UI.Phone.CallNotification+<>c__DisplayClass14_0+<<SetIsOpen>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5F0 RID: 58864 RVA: 0x0035D540 File Offset: 0x0035B740
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique()
				{
					Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "<<SetIsOpen>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>1__state");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>2__current");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>4__this");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startX>5__2");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endX>5__3");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startAlpha>5__4");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endAlpha>5__5");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<lerpTime>5__6");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<i>5__7");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682028);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682029);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682030);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682031);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682032);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682033);
				}

				// Token: 0x0600E5F1 RID: 58865 RVA: 0x0035D698 File Offset: 0x0035B898
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5F2 RID: 58866 RVA: 0x0035D6E0 File Offset: 0x0035B8E0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5F3 RID: 58867 RVA: 0x0035D714 File Offset: 0x0035B914
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271279, XrefRangeEnd = 271307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004794 RID: 18324
				// (get) Token: 0x0600E5F4 RID: 58868 RVA: 0x0035D750 File Offset: 0x0035B950
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5F5 RID: 58869 RVA: 0x0035D790 File Offset: 0x0035B990
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271307, XrefRangeEnd = 271312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004795 RID: 18325
				// (get) Token: 0x0600E5F6 RID: 58870 RVA: 0x0035D7C4 File Offset: 0x0035B9C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5F7 RID: 58871 RVA: 0x00070349 File Offset: 0x0006E549
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700478B RID: 18315
				// (get) Token: 0x0600E5F8 RID: 58872 RVA: 0x0035D804 File Offset: 0x0035BA04
				// (set) Token: 0x0600E5F9 RID: 58873 RVA: 0x00070352 File Offset: 0x0006E552
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700478C RID: 18316
				// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x0035D82C File Offset: 0x0035BA2C
				// (set) Token: 0x0600E5FB RID: 58875 RVA: 0x0007036D File Offset: 0x0006E56D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700478D RID: 18317
				// (get) Token: 0x0600E5FC RID: 58876 RVA: 0x0035D85C File Offset: 0x0035BA5C
				// (set) Token: 0x0600E5FD RID: 58877 RVA: 0x0007038C File Offset: 0x0006E58C
				public unsafe CallNotification.__c__DisplayClass14_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallNotification.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700478E RID: 18318
				// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x0035D88C File Offset: 0x0035BA8C
				// (set) Token: 0x0600E5FF RID: 58879 RVA: 0x000703AB File Offset: 0x0006E5AB
				public unsafe float _startX_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x1700478F RID: 18319
				// (get) Token: 0x0600E600 RID: 58880 RVA: 0x0035D8B4 File Offset: 0x0035BAB4
				// (set) Token: 0x0600E601 RID: 58881 RVA: 0x000703C6 File Offset: 0x0006E5C6
				public unsafe float _endX_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3)) = value;
					}
				}

				// Token: 0x17004790 RID: 18320
				// (get) Token: 0x0600E602 RID: 58882 RVA: 0x0035D8DC File Offset: 0x0035BADC
				// (set) Token: 0x0600E603 RID: 58883 RVA: 0x000703E1 File Offset: 0x0006E5E1
				public unsafe float _startAlpha_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4)) = value;
					}
				}

				// Token: 0x17004791 RID: 18321
				// (get) Token: 0x0600E604 RID: 58884 RVA: 0x0035D904 File Offset: 0x0035BB04
				// (set) Token: 0x0600E605 RID: 58885 RVA: 0x000703FC File Offset: 0x0006E5FC
				public unsafe float _endAlpha_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5)) = value;
					}
				}

				// Token: 0x17004792 RID: 18322
				// (get) Token: 0x0600E606 RID: 58886 RVA: 0x0035D92C File Offset: 0x0035BB2C
				// (set) Token: 0x0600E607 RID: 58887 RVA: 0x00070417 File Offset: 0x0006E617
				public unsafe float _lerpTime_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6)) = value;
					}
				}

				// Token: 0x17004793 RID: 18323
				// (get) Token: 0x0600E608 RID: 58888 RVA: 0x0035D954 File Offset: 0x0035BB54
				// (set) Token: 0x0600E609 RID: 58889 RVA: 0x00070432 File Offset: 0x0006E632
				public unsafe float _i_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7)) = value;
					}
				}

				// Token: 0x040099B6 RID: 39350
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099B7 RID: 39351
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099B8 RID: 39352
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099B9 RID: 39353
				private static readonly IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x040099BA RID: 39354
				private static readonly IntPtr NativeFieldInfoPtr__endX_5__3;

				// Token: 0x040099BB RID: 39355
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__4;

				// Token: 0x040099BC RID: 39356
				private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__5;

				// Token: 0x040099BD RID: 39357
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__6;

				// Token: 0x040099BE RID: 39358
				private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

				// Token: 0x040099BF RID: 39359
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099C0 RID: 39360
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099C1 RID: 39361
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099C2 RID: 39362
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099C3 RID: 39363
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099C4 RID: 39364
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
