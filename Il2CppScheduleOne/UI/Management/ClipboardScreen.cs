using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006B8 RID: 1720
	public class ClipboardScreen : MonoBehaviour
	{
		// Token: 0x06009B1C RID: 39708 RVA: 0x00275F34 File Offset: 0x00274134
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardScreen()
		{
			Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ClipboardScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr);
			ClipboardScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			ClipboardScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "Container");
			ClipboardScreen.NativeFieldInfoPtr_ClosedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "ClosedOffset");
			ClipboardScreen.NativeFieldInfoPtr_OpenOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "OpenOnStart");
			ClipboardScreen.NativeFieldInfoPtr_UseExitListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "UseExitListener");
			ClipboardScreen.NativeFieldInfoPtr_ExitActionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "ExitActionPriority");
			ClipboardScreen.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "lerpRoutine");
			ClipboardScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682371);
			ClipboardScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682372);
			ClipboardScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682373);
			ClipboardScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682374);
			ClipboardScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682375);
			ClipboardScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682376);
			ClipboardScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682377);
			ClipboardScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682378);
			ClipboardScreen.NativeMethodInfoPtr__Close_b__13_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, 100682379);
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x06009B1D RID: 39709 RVA: 0x002760A4 File Offset: 0x002742A4
		// (set) Token: 0x06009B1E RID: 39710 RVA: 0x002760E0 File Offset: 0x002742E0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009B1F RID: 39711 RVA: 0x00276120 File Offset: 0x00274320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275494, XrefRangeEnd = 275511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x0027615C File Offset: 0x0027435C
		[CallerCount(0)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x002761A0 File Offset: 0x002743A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275515, RefRangeEnd = 275517, XrefRangeStart = 275511, XrefRangeEnd = 275515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x002761DC File Offset: 0x002743DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275524, RefRangeEnd = 275526, XrefRangeStart = 275517, XrefRangeEnd = 275524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x00276218 File Offset: 0x00274418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275548, RefRangeEnd = 275550, XrefRangeStart = 275526, XrefRangeEnd = 275548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lerp(bool open, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x00276268 File Offset: 0x00274468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275551, RefRangeEnd = 275553, XrefRangeStart = 275550, XrefRangeEnd = 275551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x002762A4 File Offset: 0x002744A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275553, XrefRangeEnd = 275556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Close_b__13_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.NativeMethodInfoPtr__Close_b__13_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x0004BF2B File Offset: 0x0004A12B
		public ClipboardScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x002762D8 File Offset: 0x002744D8
		// (set) Token: 0x06009B28 RID: 39720 RVA: 0x0004BF34 File Offset: 0x0004A134
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x06009B29 RID: 39721 RVA: 0x00276300 File Offset: 0x00274500
		// (set) Token: 0x06009B2A RID: 39722 RVA: 0x0004BF4F File Offset: 0x0004A14F
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x00276330 File Offset: 0x00274530
		// (set) Token: 0x06009B2C RID: 39724 RVA: 0x0004BF6E File Offset: 0x0004A16E
		public unsafe float ClosedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ClosedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ClosedOffset)) = value;
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x06009B2D RID: 39725 RVA: 0x00276358 File Offset: 0x00274558
		// (set) Token: 0x06009B2E RID: 39726 RVA: 0x0004BF89 File Offset: 0x0004A189
		public unsafe bool OpenOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_OpenOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_OpenOnStart)) = value;
			}
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x00276380 File Offset: 0x00274580
		// (set) Token: 0x06009B30 RID: 39728 RVA: 0x0004BFA4 File Offset: 0x0004A1A4
		public unsafe bool UseExitListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_UseExitListener);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_UseExitListener)) = value;
			}
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x06009B31 RID: 39729 RVA: 0x002763A8 File Offset: 0x002745A8
		// (set) Token: 0x06009B32 RID: 39730 RVA: 0x0004BFBF File Offset: 0x0004A1BF
		public unsafe int ExitActionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ExitActionPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_ExitActionPriority)) = value;
			}
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x06009B33 RID: 39731 RVA: 0x002763D0 File Offset: 0x002745D0
		// (set) Token: 0x06009B34 RID: 39732 RVA: 0x0004BFDA File Offset: 0x0004A1DA
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006849 RID: 26697
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400684A RID: 26698
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400684B RID: 26699
		private static readonly IntPtr NativeFieldInfoPtr_ClosedOffset;

		// Token: 0x0400684C RID: 26700
		private static readonly IntPtr NativeFieldInfoPtr_OpenOnStart;

		// Token: 0x0400684D RID: 26701
		private static readonly IntPtr NativeFieldInfoPtr_UseExitListener;

		// Token: 0x0400684E RID: 26702
		private static readonly IntPtr NativeFieldInfoPtr_ExitActionPriority;

		// Token: 0x0400684F RID: 26703
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04006850 RID: 26704
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006851 RID: 26705
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006852 RID: 26706
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006853 RID: 26707
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006854 RID: 26708
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x04006855 RID: 26709
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04006856 RID: 26710
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Void_Boolean_Action_0;

		// Token: 0x04006857 RID: 26711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006858 RID: 26712
		private static readonly IntPtr NativeMethodInfoPtr__Close_b__13_0_Private_Void_0;

		// Token: 0x02000B8A RID: 2954
		[ObfuscatedName("ScheduleOne.UI.Management.ClipboardScreen+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBC4 RID: 56260 RVA: 0x0033FF7C File Offset: 0x0033E17C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipboardScreen>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr);
				ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "open");
				ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "callback");
				ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, 100682380);
				ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, 100682381);
			}

			// Token: 0x0600DBC5 RID: 56261 RVA: 0x0034000C File Offset: 0x0033E20C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC6 RID: 56262 RVA: 0x00340048 File Offset: 0x0033E248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275489, XrefRangeEnd = 275494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DBC7 RID: 56263 RVA: 0x0006B116 File Offset: 0x00069316
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004425 RID: 17445
			// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x00340088 File Offset: 0x0033E288
			// (set) Token: 0x0600DBC9 RID: 56265 RVA: 0x0006B11F File Offset: 0x0006931F
			public unsafe ClipboardScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004426 RID: 17446
			// (get) Token: 0x0600DBCA RID: 56266 RVA: 0x003400B8 File Offset: 0x0033E2B8
			// (set) Token: 0x0600DBCB RID: 56267 RVA: 0x0006B13E File Offset: 0x0006933E
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x17004427 RID: 17447
			// (get) Token: 0x0600DBCC RID: 56268 RVA: 0x003400E0 File Offset: 0x0033E2E0
			// (set) Token: 0x0600DBCD RID: 56269 RVA: 0x0006B159 File Offset: 0x00069359
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400935C RID: 37724
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400935D RID: 37725
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x0400935E RID: 37726
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400935F RID: 37727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009360 RID: 37728
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7F RID: 3199
			[ObfuscatedName("ScheduleOne.UI.Management.ClipboardScreen+<>c__DisplayClass14_0+<<Lerp>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E64E RID: 58958 RVA: 0x0035E634 File Offset: 0x0035C834
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0>.NativeClassPtr, "<<Lerp>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startX>5__2");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endX_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<endX>5__3");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682382);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682383);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682384);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682385);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682386);
					ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682387);
				}

				// Token: 0x0600E64F RID: 58959 RVA: 0x0035E750 File Offset: 0x0035C950
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E650 RID: 58960 RVA: 0x0035E798 File Offset: 0x0035C998
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E651 RID: 58961 RVA: 0x0035E7CC File Offset: 0x0035C9CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275469, XrefRangeEnd = 275484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047B6 RID: 18358
				// (get) Token: 0x0600E652 RID: 58962 RVA: 0x0035E808 File Offset: 0x0035CA08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E653 RID: 58963 RVA: 0x0035E848 File Offset: 0x0035CA48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275484, XrefRangeEnd = 275489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047B7 RID: 18359
				// (get) Token: 0x0600E654 RID: 58964 RVA: 0x0035E87C File Offset: 0x0035CA7C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E655 RID: 58965 RVA: 0x00070677 File Offset: 0x0006E877
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047B0 RID: 18352
				// (get) Token: 0x0600E656 RID: 58966 RVA: 0x0035E8BC File Offset: 0x0035CABC
				// (set) Token: 0x0600E657 RID: 58967 RVA: 0x00070680 File Offset: 0x0006E880
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047B1 RID: 18353
				// (get) Token: 0x0600E658 RID: 58968 RVA: 0x0035E8E4 File Offset: 0x0035CAE4
				// (set) Token: 0x0600E659 RID: 58969 RVA: 0x0007069B File Offset: 0x0006E89B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B2 RID: 18354
				// (get) Token: 0x0600E65A RID: 58970 RVA: 0x0035E914 File Offset: 0x0035CB14
				// (set) Token: 0x0600E65B RID: 58971 RVA: 0x000706BA File Offset: 0x0006E8BA
				public unsafe ClipboardScreen.__c__DisplayClass14_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B3 RID: 18355
				// (get) Token: 0x0600E65C RID: 58972 RVA: 0x0035E944 File Offset: 0x0035CB44
				// (set) Token: 0x0600E65D RID: 58973 RVA: 0x000706D9 File Offset: 0x0006E8D9
				public unsafe float _startX_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x170047B4 RID: 18356
				// (get) Token: 0x0600E65E RID: 58974 RVA: 0x0035E96C File Offset: 0x0035CB6C
				// (set) Token: 0x0600E65F RID: 58975 RVA: 0x000706F4 File Offset: 0x0006E8F4
				public unsafe float _endX_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endX_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endX_5__3)) = value;
					}
				}

				// Token: 0x170047B5 RID: 18357
				// (get) Token: 0x0600E660 RID: 58976 RVA: 0x0035E994 File Offset: 0x0035CB94
				// (set) Token: 0x0600E661 RID: 58977 RVA: 0x0007070F File Offset: 0x0006E90F
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipboardScreen.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040099EF RID: 39407
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099F0 RID: 39408
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099F1 RID: 39409
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099F2 RID: 39410
				private static readonly IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x040099F3 RID: 39411
				private static readonly IntPtr NativeFieldInfoPtr__endX_5__3;

				// Token: 0x040099F4 RID: 39412
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040099F5 RID: 39413
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099F6 RID: 39414
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099F7 RID: 39415
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099F8 RID: 39416
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099F9 RID: 39417
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099FA RID: 39418
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
