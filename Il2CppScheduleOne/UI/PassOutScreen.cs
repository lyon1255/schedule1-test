using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065A RID: 1626
	public class PassOutScreen : Singleton<PassOutScreen>
	{
		// Token: 0x06009111 RID: 37137 RVA: 0x002580F4 File Offset: 0x002562F4
		// Note: this type is marked as 'beforefieldinit'.
		static PassOutScreen()
		{
			Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PassOutScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr);
			PassOutScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "CASH_LOSS_MIN");
			PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "CASH_LOSS_MAX");
			PassOutScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "Canvas");
			PassOutScreen.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "Group");
			PassOutScreen.NativeFieldInfoPtr_RecoveryPointsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "RecoveryPointsContainer");
			PassOutScreen.NativeFieldInfoPtr_MainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "MainLabel");
			PassOutScreen.NativeFieldInfoPtr_ContextLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "ContextLabel");
			PassOutScreen.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "Anim");
			PassOutScreen.NativeFieldInfoPtr_cashLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "cashLoss");
			PassOutScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681264);
			PassOutScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681265);
			PassOutScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681266);
			PassOutScreen.NativeMethodInfoPtr_Continue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681267);
			PassOutScreen.NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681268);
			PassOutScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681269);
			PassOutScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681270);
			PassOutScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681271);
			PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681272);
			PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, 100681273);
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x002582B4 File Offset: 0x002564B4
		// (set) Token: 0x06009113 RID: 37139 RVA: 0x002582F0 File Offset: 0x002564F0
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x00258330 File Offset: 0x00256530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262428, XrefRangeEnd = 262435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassOutScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x0025836C File Offset: 0x0025656C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262435, XrefRangeEnd = 262441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Continue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x002583A0 File Offset: 0x002565A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262441, XrefRangeEnd = 262442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x002583D4 File Offset: 0x002565D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262465, RefRangeEnd = 262466, XrefRangeStart = 262442, XrefRangeEnd = 262465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009118 RID: 37144 RVA: 0x00258408 File Offset: 0x00256608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262489, RefRangeEnd = 262491, XrefRangeStart = 262466, XrefRangeEnd = 262489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009119 RID: 37145 RVA: 0x0025843C File Offset: 0x0025663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262491, XrefRangeEnd = 262494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassOutScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600911A RID: 37146 RVA: 0x00258478 File Offset: 0x00256678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262494, XrefRangeEnd = 262499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600911B RID: 37147 RVA: 0x002584B8 File Offset: 0x002566B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262499, XrefRangeEnd = 262504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x000461B1 File Offset: 0x000443B1
		public PassOutScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x002584F8 File Offset: 0x002566F8
		// (set) Token: 0x0600911E RID: 37150 RVA: 0x000461BA File Offset: 0x000443BA
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600911F RID: 37151 RVA: 0x00258520 File Offset: 0x00256720
		// (set) Token: 0x06009120 RID: 37152 RVA: 0x000461D5 File Offset: 0x000443D5
		public unsafe static float CASH_LOSS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06009121 RID: 37153 RVA: 0x0025853C File Offset: 0x0025673C
		// (set) Token: 0x06009122 RID: 37154 RVA: 0x000461E3 File Offset: 0x000443E3
		public unsafe static float CASH_LOSS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PassOutScreen.NativeFieldInfoPtr_CASH_LOSS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06009123 RID: 37155 RVA: 0x00258558 File Offset: 0x00256758
		// (set) Token: 0x06009124 RID: 37156 RVA: 0x000461F1 File Offset: 0x000443F1
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06009125 RID: 37157 RVA: 0x00258588 File Offset: 0x00256788
		// (set) Token: 0x06009126 RID: 37158 RVA: 0x00046210 File Offset: 0x00044410
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06009127 RID: 37159 RVA: 0x002585B8 File Offset: 0x002567B8
		// (set) Token: 0x06009128 RID: 37160 RVA: 0x0004622F File Offset: 0x0004442F
		public unsafe Transform RecoveryPointsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_RecoveryPointsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_RecoveryPointsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x002585E8 File Offset: 0x002567E8
		// (set) Token: 0x0600912A RID: 37162 RVA: 0x0004624E File Offset: 0x0004444E
		public unsafe TextMeshProUGUI MainLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_MainLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_MainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600912B RID: 37163 RVA: 0x00258618 File Offset: 0x00256818
		// (set) Token: 0x0600912C RID: 37164 RVA: 0x0004626D File Offset: 0x0004446D
		public unsafe TextMeshProUGUI ContextLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_ContextLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_ContextLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600912D RID: 37165 RVA: 0x00258648 File Offset: 0x00256848
		// (set) Token: 0x0600912E RID: 37166 RVA: 0x0004628C File Offset: 0x0004448C
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x00258678 File Offset: 0x00256878
		// (set) Token: 0x06009130 RID: 37168 RVA: 0x000462AB File Offset: 0x000444AB
		public unsafe float cashLoss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_cashLoss);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.NativeFieldInfoPtr_cashLoss)) = value;
			}
		}

		// Token: 0x0400620E RID: 25102
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400620F RID: 25103
		private static readonly IntPtr NativeFieldInfoPtr_CASH_LOSS_MIN;

		// Token: 0x04006210 RID: 25104
		private static readonly IntPtr NativeFieldInfoPtr_CASH_LOSS_MAX;

		// Token: 0x04006211 RID: 25105
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006212 RID: 25106
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04006213 RID: 25107
		private static readonly IntPtr NativeFieldInfoPtr_RecoveryPointsContainer;

		// Token: 0x04006214 RID: 25108
		private static readonly IntPtr NativeFieldInfoPtr_MainLabel;

		// Token: 0x04006215 RID: 25109
		private static readonly IntPtr NativeFieldInfoPtr_ContextLabel;

		// Token: 0x04006216 RID: 25110
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04006217 RID: 25111
		private static readonly IntPtr NativeFieldInfoPtr_cashLoss;

		// Token: 0x04006218 RID: 25112
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006219 RID: 25113
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400621A RID: 25114
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400621B RID: 25115
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Private_Void_0;

		// Token: 0x0400621C RID: 25116
		private static readonly IntPtr NativeMethodInfoPtr_LoadSaveClicked_Private_Void_0;

		// Token: 0x0400621D RID: 25117
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400621E RID: 25118
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400621F RID: 25119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006220 RID: 25120
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006221 RID: 25121
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B40 RID: 2880
		[ObfuscatedName("ScheduleOne.UI.PassOutScreen+<<Continue>g__Routine|14_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D8BE RID: 55486 RVA: 0x003374C4 File Offset: 0x003356C4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique()
			{
				Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "<<Continue>g__Routine|14_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<>1__state");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<>2__current");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<>4__this");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<fadeTime>5__2");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeBlur_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<fadeBlur>5__3");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<lerpTime>5__4");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, "<i>5__5");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681274);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681275);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681276);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681277);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681278);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr, 100681279);
			}

			// Token: 0x0600D8BF RID: 55487 RVA: 0x003375F4 File Offset: 0x003357F4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C0 RID: 55488 RVA: 0x0033763C File Offset: 0x0033583C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8C1 RID: 55489 RVA: 0x00337670 File Offset: 0x00335870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262282, XrefRangeEnd = 262408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004341 RID: 17217
			// (get) Token: 0x0600D8C2 RID: 55490 RVA: 0x003376AC File Offset: 0x003358AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8C3 RID: 55491 RVA: 0x003376EC File Offset: 0x003358EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262408, XrefRangeEnd = 262413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004342 RID: 17218
			// (get) Token: 0x0600D8C4 RID: 55492 RVA: 0x00337720 File Offset: 0x00335920
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8C5 RID: 55493 RVA: 0x0006990D File Offset: 0x00067B0D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700433A RID: 17210
			// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x00337760 File Offset: 0x00335960
			// (set) Token: 0x0600D8C7 RID: 55495 RVA: 0x00069916 File Offset: 0x00067B16
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700433B RID: 17211
			// (get) Token: 0x0600D8C8 RID: 55496 RVA: 0x00337788 File Offset: 0x00335988
			// (set) Token: 0x0600D8C9 RID: 55497 RVA: 0x00069931 File Offset: 0x00067B31
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700433C RID: 17212
			// (get) Token: 0x0600D8CA RID: 55498 RVA: 0x003377B8 File Offset: 0x003359B8
			// (set) Token: 0x0600D8CB RID: 55499 RVA: 0x00069950 File Offset: 0x00067B50
			public unsafe PassOutScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassOutScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700433D RID: 17213
			// (get) Token: 0x0600D8CC RID: 55500 RVA: 0x003377E8 File Offset: 0x003359E8
			// (set) Token: 0x0600D8CD RID: 55501 RVA: 0x0006996F File Offset: 0x00067B6F
			public unsafe float _fadeTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeTime_5__2)) = value;
				}
			}

			// Token: 0x1700433E RID: 17214
			// (get) Token: 0x0600D8CE RID: 55502 RVA: 0x00337810 File Offset: 0x00335A10
			// (set) Token: 0x0600D8CF RID: 55503 RVA: 0x0006998A File Offset: 0x00067B8A
			public unsafe bool _fadeBlur_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeBlur_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__fadeBlur_5__3)) = value;
				}
			}

			// Token: 0x1700433F RID: 17215
			// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x00337838 File Offset: 0x00335A38
			// (set) Token: 0x0600D8D1 RID: 55505 RVA: 0x000699A5 File Offset: 0x00067BA5
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17004340 RID: 17216
			// (get) Token: 0x0600D8D2 RID: 55506 RVA: 0x00337860 File Offset: 0x00335A60
			// (set) Token: 0x0600D8D3 RID: 55507 RVA: 0x000699C0 File Offset: 0x00067BC0
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiBoSiObSiObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040091A4 RID: 37284
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091A5 RID: 37285
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091A6 RID: 37286
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091A7 RID: 37287
			private static readonly IntPtr NativeFieldInfoPtr__fadeTime_5__2;

			// Token: 0x040091A8 RID: 37288
			private static readonly IntPtr NativeFieldInfoPtr__fadeBlur_5__3;

			// Token: 0x040091A9 RID: 37289
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x040091AA RID: 37290
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040091AB RID: 37291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040091AC RID: 37292
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091AD RID: 37293
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040091AE RID: 37294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040091AF RID: 37295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091B0 RID: 37296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B41 RID: 2881
		[ObfuscatedName("ScheduleOne.UI.PassOutScreen+<<Open>g__Routine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D8D4 RID: 55508 RVA: 0x00337888 File Offset: 0x00335A88
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique()
			{
				Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassOutScreen>.NativeClassPtr, "<<Open>g__Routine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<>1__state");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<>2__current");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<>4__this");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<lerpTime>5__2");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__startOpenness_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<startOpenness>5__3");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__endOpenness_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<endOpenness>5__4");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, "<i>5__5");
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681280);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681281);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681282);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681283);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681284);
				PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr, 100681285);
			}

			// Token: 0x0600D8D5 RID: 55509 RVA: 0x003379B8 File Offset: 0x00335BB8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8D6 RID: 55510 RVA: 0x00337A00 File Offset: 0x00335C00
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8D7 RID: 55511 RVA: 0x00337A34 File Offset: 0x00335C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262413, XrefRangeEnd = 262423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700434A RID: 17226
			// (get) Token: 0x0600D8D8 RID: 55512 RVA: 0x00337A70 File Offset: 0x00335C70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8D9 RID: 55513 RVA: 0x00337AB0 File Offset: 0x00335CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262423, XrefRangeEnd = 262428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700434B RID: 17227
			// (get) Token: 0x0600D8DA RID: 55514 RVA: 0x00337AE4 File Offset: 0x00335CE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8DB RID: 55515 RVA: 0x000699DB File Offset: 0x00067BDB
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004343 RID: 17219
			// (get) Token: 0x0600D8DC RID: 55516 RVA: 0x00337B24 File Offset: 0x00335D24
			// (set) Token: 0x0600D8DD RID: 55517 RVA: 0x000699E4 File Offset: 0x00067BE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004344 RID: 17220
			// (get) Token: 0x0600D8DE RID: 55518 RVA: 0x00337B4C File Offset: 0x00335D4C
			// (set) Token: 0x0600D8DF RID: 55519 RVA: 0x000699FF File Offset: 0x00067BFF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004345 RID: 17221
			// (get) Token: 0x0600D8E0 RID: 55520 RVA: 0x00337B7C File Offset: 0x00335D7C
			// (set) Token: 0x0600D8E1 RID: 55521 RVA: 0x00069A1E File Offset: 0x00067C1E
			public unsafe PassOutScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassOutScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004346 RID: 17222
			// (get) Token: 0x0600D8E2 RID: 55522 RVA: 0x00337BAC File Offset: 0x00335DAC
			// (set) Token: 0x0600D8E3 RID: 55523 RVA: 0x00069A3D File Offset: 0x00067C3D
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004347 RID: 17223
			// (get) Token: 0x0600D8E4 RID: 55524 RVA: 0x00337BD4 File Offset: 0x00335DD4
			// (set) Token: 0x0600D8E5 RID: 55525 RVA: 0x00069A58 File Offset: 0x00067C58
			public unsafe float _startOpenness_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__startOpenness_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__startOpenness_5__3)) = value;
				}
			}

			// Token: 0x17004348 RID: 17224
			// (get) Token: 0x0600D8E6 RID: 55526 RVA: 0x00337BFC File Offset: 0x00335DFC
			// (set) Token: 0x0600D8E7 RID: 55527 RVA: 0x00069A73 File Offset: 0x00067C73
			public unsafe float _endOpenness_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__endOpenness_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__endOpenness_5__4)) = value;
				}
			}

			// Token: 0x17004349 RID: 17225
			// (get) Token: 0x0600D8E8 RID: 55528 RVA: 0x00337C24 File Offset: 0x00335E24
			// (set) Token: 0x0600D8E9 RID: 55529 RVA: 0x00069A8E File Offset: 0x00067C8E
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PassOutScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaSiSiObSiObSiUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040091B1 RID: 37297
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091B2 RID: 37298
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091B3 RID: 37299
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091B4 RID: 37300
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x040091B5 RID: 37301
			private static readonly IntPtr NativeFieldInfoPtr__startOpenness_5__3;

			// Token: 0x040091B6 RID: 37302
			private static readonly IntPtr NativeFieldInfoPtr__endOpenness_5__4;

			// Token: 0x040091B7 RID: 37303
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040091B8 RID: 37304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040091B9 RID: 37305
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091BA RID: 37306
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040091BB RID: 37307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040091BC RID: 37308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091BD RID: 37309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
