using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072F RID: 1839
	public class Bed : NetworkBehaviour
	{
		// Token: 0x0600A714 RID: 42772 RVA: 0x0029C3C4 File Offset: 0x0029A5C4
		// Note: this type is marked as 'beforefieldinit'.
		static Bed()
		{
			Il2CppClassPointerStore<Bed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Bed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bed>.NativeClassPtr);
			Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "MIN_SLEEP_TIME");
			Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "SLEEP_TIME_SCALE");
			Bed.NativeFieldInfoPtr__AssignedEmployee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "<AssignedEmployee>k__BackingField");
			Bed.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "intObj");
			Bed.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "Clipboard");
			Bed.NativeFieldInfoPtr_MugshotSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "MugshotSprite");
			Bed.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NameLabel");
			Bed.NativeFieldInfoPtr_BlanketMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BlanketMesh");
			Bed.NativeFieldInfoPtr_DefaultBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "DefaultBlanket");
			Bed.NativeFieldInfoPtr_BotanistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BotanistBlanket");
			Bed.NativeFieldInfoPtr_ChemistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "ChemistBlanket");
			Bed.NativeFieldInfoPtr_PackagerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "PackagerBlanket");
			Bed.NativeFieldInfoPtr_CleanerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "CleanerBlanket");
			Bed.NativeFieldInfoPtr_onAssignedEmployeeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "onAssignedEmployeeChanged");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683745);
			Bed.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683746);
			Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683747);
			Bed.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683748);
			Bed.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683749);
			Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683750);
			Bed.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683751);
			Bed.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683752);
			Bed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683753);
			Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683754);
			Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683755);
			Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683756);
			Bed.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100683757);
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600A715 RID: 42773 RVA: 0x0029C638 File Offset: 0x0029A838
		// (set) Token: 0x0600A716 RID: 42774 RVA: 0x0029C678 File Offset: 0x0029A878
		public unsafe Employee AssignedEmployee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x0029C6BC File Offset: 0x0029A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291049, XrefRangeEnd = 291057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x0029C6F8 File Offset: 0x0029A8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291057, XrefRangeEnd = 291084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x0029C72C File Offset: 0x0029A92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291084, XrefRangeEnd = 291095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x0029C760 File Offset: 0x0029A960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291095, XrefRangeEnd = 291101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x0029C79C File Offset: 0x0029A99C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 291116, RefRangeEnd = 291124, XrefRangeStart = 291101, XrefRangeEnd = 291116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x0029C7E0 File Offset: 0x0029A9E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291135, RefRangeEnd = 291138, XrefRangeStart = 291124, XrefRangeEnd = 291135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x0029C814 File Offset: 0x0029AA14
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x0029C850 File Offset: 0x0029AA50
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x0029C88C File Offset: 0x0029AA8C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x0029C8C8 File Offset: 0x0029AAC8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x0029C904 File Offset: 0x0029AB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291138, XrefRangeEnd = 291146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x000524F7 File Offset: 0x000506F7
		public Bed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600A723 RID: 42787 RVA: 0x0029C938 File Offset: 0x0029AB38
		// (set) Token: 0x0600A724 RID: 42788 RVA: 0x00052500 File Offset: 0x00050700
		public unsafe static int MIN_SLEEP_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600A725 RID: 42789 RVA: 0x0029C954 File Offset: 0x0029AB54
		// (set) Token: 0x0600A726 RID: 42790 RVA: 0x0005250E File Offset: 0x0005070E
		public unsafe static float SLEEP_TIME_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600A727 RID: 42791 RVA: 0x0029C970 File Offset: 0x0029AB70
		// (set) Token: 0x0600A728 RID: 42792 RVA: 0x0005251C File Offset: 0x0005071C
		public unsafe Employee _AssignedEmployee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr__AssignedEmployee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr__AssignedEmployee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x0029C9A0 File Offset: 0x0029ABA0
		// (set) Token: 0x0600A72A RID: 42794 RVA: 0x0005253B File Offset: 0x0005073B
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600A72B RID: 42795 RVA: 0x0029C9D0 File Offset: 0x0029ABD0
		// (set) Token: 0x0600A72C RID: 42796 RVA: 0x0005255A File Offset: 0x0005075A
		public unsafe GameObject Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x0029CA00 File Offset: 0x0029AC00
		// (set) Token: 0x0600A72E RID: 42798 RVA: 0x00052579 File Offset: 0x00050779
		public unsafe SpriteRenderer MugshotSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_MugshotSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_MugshotSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x0029CA30 File Offset: 0x0029AC30
		// (set) Token: 0x0600A730 RID: 42800 RVA: 0x00052598 File Offset: 0x00050798
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600A731 RID: 42801 RVA: 0x0029CA60 File Offset: 0x0029AC60
		// (set) Token: 0x0600A732 RID: 42802 RVA: 0x000525B7 File Offset: 0x000507B7
		public unsafe MeshRenderer BlanketMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600A733 RID: 42803 RVA: 0x0029CA90 File Offset: 0x0029AC90
		// (set) Token: 0x0600A734 RID: 42804 RVA: 0x000525D6 File Offset: 0x000507D6
		public unsafe Material DefaultBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600A735 RID: 42805 RVA: 0x0029CAC0 File Offset: 0x0029ACC0
		// (set) Token: 0x0600A736 RID: 42806 RVA: 0x000525F5 File Offset: 0x000507F5
		public unsafe Material BotanistBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600A737 RID: 42807 RVA: 0x0029CAF0 File Offset: 0x0029ACF0
		// (set) Token: 0x0600A738 RID: 42808 RVA: 0x00052614 File Offset: 0x00050814
		public unsafe Material ChemistBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600A739 RID: 42809 RVA: 0x0029CB20 File Offset: 0x0029AD20
		// (set) Token: 0x0600A73A RID: 42810 RVA: 0x00052633 File Offset: 0x00050833
		public unsafe Material PackagerBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x0029CB50 File Offset: 0x0029AD50
		// (set) Token: 0x0600A73C RID: 42812 RVA: 0x00052652 File Offset: 0x00050852
		public unsafe Material CleanerBlanket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x0029CB80 File Offset: 0x0029AD80
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x00052671 File Offset: 0x00050871
		public unsafe UnityEvent onAssignedEmployeeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_onAssignedEmployeeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_onAssignedEmployeeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x0029CBB0 File Offset: 0x0029ADB0
		// (set) Token: 0x0600A740 RID: 42816 RVA: 0x00052690 File Offset: 0x00050890
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x0029CBD8 File Offset: 0x0029ADD8
		// (set) Token: 0x0600A742 RID: 42818 RVA: 0x000526AB File Offset: 0x000508AB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007013 RID: 28691
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SLEEP_TIME;

		// Token: 0x04007014 RID: 28692
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP_TIME_SCALE;

		// Token: 0x04007015 RID: 28693
		private static readonly IntPtr NativeFieldInfoPtr__AssignedEmployee_k__BackingField;

		// Token: 0x04007016 RID: 28694
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04007017 RID: 28695
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x04007018 RID: 28696
		private static readonly IntPtr NativeFieldInfoPtr_MugshotSprite;

		// Token: 0x04007019 RID: 28697
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x0400701A RID: 28698
		private static readonly IntPtr NativeFieldInfoPtr_BlanketMesh;

		// Token: 0x0400701B RID: 28699
		private static readonly IntPtr NativeFieldInfoPtr_DefaultBlanket;

		// Token: 0x0400701C RID: 28700
		private static readonly IntPtr NativeFieldInfoPtr_BotanistBlanket;

		// Token: 0x0400701D RID: 28701
		private static readonly IntPtr NativeFieldInfoPtr_ChemistBlanket;

		// Token: 0x0400701E RID: 28702
		private static readonly IntPtr NativeFieldInfoPtr_PackagerBlanket;

		// Token: 0x0400701F RID: 28703
		private static readonly IntPtr NativeFieldInfoPtr_CleanerBlanket;

		// Token: 0x04007020 RID: 28704
		private static readonly IntPtr NativeFieldInfoPtr_onAssignedEmployeeChanged;

		// Token: 0x04007021 RID: 28705
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007022 RID: 28706
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007023 RID: 28707
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0;

		// Token: 0x04007024 RID: 28708
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0;

		// Token: 0x04007025 RID: 28709
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007026 RID: 28710
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007027 RID: 28711
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007028 RID: 28712
		private static readonly IntPtr NativeMethodInfoPtr_CanSleep_Private_Boolean_0;

		// Token: 0x04007029 RID: 28713
		private static readonly IntPtr NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0;

		// Token: 0x0400702A RID: 28714
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Private_Void_0;

		// Token: 0x0400702B RID: 28715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400702C RID: 28716
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400702D RID: 28717
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400702E RID: 28718
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400702F RID: 28719
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
