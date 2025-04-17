using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000754 RID: 1876
	public class Dumpster : GridItem
	{
		// Token: 0x0600B256 RID: 45654 RVA: 0x002C7E40 File Offset: 0x002C6040
		// Note: this type is marked as 'beforefieldinit'.
		static Dumpster()
		{
			Il2CppClassPointerStore<Dumpster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Dumpster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dumpster>.NativeClassPtr);
			Dumpster.NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "capacity");
			Dumpster.NativeFieldInfoPtr_lid_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid_IntObj");
			Dumpster.NativeFieldInfoPtr_inner_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "inner_IntObj");
			Dumpster.NativeFieldInfoPtr_lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid");
			Dumpster.NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash");
			Dumpster.NativeFieldInfoPtr_standPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "standPoint");
			Dumpster.NativeFieldInfoPtr_trash_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash_MinY");
			Dumpster.NativeFieldInfoPtr_trash_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash_MaxY");
			Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "<lidOpen>k__BackingField");
			Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "<currentTrashLevel>k__BackingField");
			Dumpster.NativeFieldInfoPtr_lid_CurrentAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid_CurrentAngle");
			Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted");
			Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted");
			Dumpster.NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685280);
			Dumpster.NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685281);
			Dumpster.NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685282);
			Dumpster.NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685283);
			Dumpster.NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685284);
			Dumpster.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685285);
			Dumpster.NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685286);
			Dumpster.NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685287);
			Dumpster.NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685288);
			Dumpster.NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685289);
			Dumpster.NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685290);
			Dumpster.NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685291);
			Dumpster.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685292);
			Dumpster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685293);
			Dumpster.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685295);
			Dumpster.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685296);
			Dumpster.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685297);
			Dumpster.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685298);
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600B257 RID: 45655 RVA: 0x002C80DC File Offset: 0x002C62DC
		// (set) Token: 0x0600B258 RID: 45656 RVA: 0x002C8118 File Offset: 0x002C6318
		public unsafe bool lidOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600B259 RID: 45657 RVA: 0x002C8158 File Offset: 0x002C6358
		// (set) Token: 0x0600B25A RID: 45658 RVA: 0x002C8194 File Offset: 0x002C6394
		public unsafe float currentTrashLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600B25B RID: 45659 RVA: 0x002C81D4 File Offset: 0x002C63D4
		public unsafe bool isFull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307245, XrefRangeEnd = 307249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x002C8210 File Offset: 0x002C6410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307249, XrefRangeEnd = 307255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x002C824C File Offset: 0x002C644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307255, XrefRangeEnd = 307262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Lid_Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x002C8288 File Offset: 0x002C6488
		[CallerCount(0)]
		public unsafe virtual void Lid_Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x002C82C4 File Offset: 0x002C64C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307262, XrefRangeEnd = 307273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesPlayerHaveBinEquipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B260 RID: 45664 RVA: 0x002C8300 File Offset: 0x002C6500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307273, XrefRangeEnd = 307287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTrashLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x002C8340 File Offset: 0x002C6540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307287, XrefRangeEnd = 307301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrashLevel(float trashLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trashLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x002C8380 File Offset: 0x002C6580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307301, XrefRangeEnd = 307310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTrashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x002C83B4 File Offset: 0x002C65B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307310, XrefRangeEnd = 307315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x002C8418 File Offset: 0x002C6618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dumpster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dumpster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x002C8454 File Offset: 0x002C6654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307315, XrefRangeEnd = 307316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B266 RID: 45670 RVA: 0x002C8490 File Offset: 0x002C6690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307316, XrefRangeEnd = 307317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x002C84CC File Offset: 0x002C66CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x002C8508 File Offset: 0x002C6708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290619, RefRangeEnd = 290620, XrefRangeStart = 290619, XrefRangeEnd = 290620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x00057772 File Offset: 0x00055972
		public Dumpster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x002C8544 File Offset: 0x002C6744
		// (set) Token: 0x0600B26B RID: 45675 RVA: 0x0005777B File Offset: 0x0005597B
		public unsafe static float capacity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dumpster.NativeFieldInfoPtr_capacity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dumpster.NativeFieldInfoPtr_capacity, (void*)(&value));
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600B26C RID: 45676 RVA: 0x002C8560 File Offset: 0x002C6760
		// (set) Token: 0x0600B26D RID: 45677 RVA: 0x00057789 File Offset: 0x00055989
		public unsafe InteractableObject lid_IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600B26E RID: 45678 RVA: 0x002C8590 File Offset: 0x002C6790
		// (set) Token: 0x0600B26F RID: 45679 RVA: 0x000577A8 File Offset: 0x000559A8
		public unsafe InteractableObject inner_IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_inner_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_inner_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x002C85C0 File Offset: 0x002C67C0
		// (set) Token: 0x0600B271 RID: 45681 RVA: 0x000577C7 File Offset: 0x000559C7
		public unsafe Transform lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600B272 RID: 45682 RVA: 0x002C85F0 File Offset: 0x002C67F0
		// (set) Token: 0x0600B273 RID: 45683 RVA: 0x000577E6 File Offset: 0x000559E6
		public unsafe Transform trash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600B274 RID: 45684 RVA: 0x002C8620 File Offset: 0x002C6820
		// (set) Token: 0x0600B275 RID: 45685 RVA: 0x00057805 File Offset: 0x00055A05
		public unsafe Transform standPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_standPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_standPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600B276 RID: 45686 RVA: 0x002C8650 File Offset: 0x002C6850
		// (set) Token: 0x0600B277 RID: 45687 RVA: 0x00057824 File Offset: 0x00055A24
		public unsafe float trash_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MinY)) = value;
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x002C8678 File Offset: 0x002C6878
		// (set) Token: 0x0600B279 RID: 45689 RVA: 0x0005783F File Offset: 0x00055A3F
		public unsafe float trash_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MaxY)) = value;
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x002C86A0 File Offset: 0x002C68A0
		// (set) Token: 0x0600B27B RID: 45691 RVA: 0x0005785A File Offset: 0x00055A5A
		public unsafe bool _lidOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x002C86C8 File Offset: 0x002C68C8
		// (set) Token: 0x0600B27D RID: 45693 RVA: 0x00057875 File Offset: 0x00055A75
		public unsafe float _currentTrashLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x002C86F0 File Offset: 0x002C68F0
		// (set) Token: 0x0600B27F RID: 45695 RVA: 0x00057890 File Offset: 0x00055A90
		public unsafe float lid_CurrentAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_CurrentAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_CurrentAngle)) = value;
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x002C8718 File Offset: 0x002C6918
		// (set) Token: 0x0600B281 RID: 45697 RVA: 0x000578AB File Offset: 0x00055AAB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x002C8740 File Offset: 0x002C6940
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x000578C6 File Offset: 0x00055AC6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007847 RID: 30791
		private static readonly IntPtr NativeFieldInfoPtr_capacity;

		// Token: 0x04007848 RID: 30792
		private static readonly IntPtr NativeFieldInfoPtr_lid_IntObj;

		// Token: 0x04007849 RID: 30793
		private static readonly IntPtr NativeFieldInfoPtr_inner_IntObj;

		// Token: 0x0400784A RID: 30794
		private static readonly IntPtr NativeFieldInfoPtr_lid;

		// Token: 0x0400784B RID: 30795
		private static readonly IntPtr NativeFieldInfoPtr_trash;

		// Token: 0x0400784C RID: 30796
		private static readonly IntPtr NativeFieldInfoPtr_standPoint;

		// Token: 0x0400784D RID: 30797
		private static readonly IntPtr NativeFieldInfoPtr_trash_MinY;

		// Token: 0x0400784E RID: 30798
		private static readonly IntPtr NativeFieldInfoPtr_trash_MaxY;

		// Token: 0x0400784F RID: 30799
		private static readonly IntPtr NativeFieldInfoPtr__lidOpen_k__BackingField;

		// Token: 0x04007850 RID: 30800
		private static readonly IntPtr NativeFieldInfoPtr__currentTrashLevel_k__BackingField;

		// Token: 0x04007851 RID: 30801
		private static readonly IntPtr NativeFieldInfoPtr_lid_CurrentAngle;

		// Token: 0x04007852 RID: 30802
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007853 RID: 30803
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007854 RID: 30804
		private static readonly IntPtr NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0;

		// Token: 0x04007855 RID: 30805
		private static readonly IntPtr NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007856 RID: 30806
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0;

		// Token: 0x04007857 RID: 30807
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0;

		// Token: 0x04007858 RID: 30808
		private static readonly IntPtr NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0;

		// Token: 0x04007859 RID: 30809
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400785A RID: 30810
		private static readonly IntPtr NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x0400785B RID: 30811
		private static readonly IntPtr NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x0400785C RID: 30812
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0;

		// Token: 0x0400785D RID: 30813
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0;

		// Token: 0x0400785E RID: 30814
		private static readonly IntPtr NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0;

		// Token: 0x0400785F RID: 30815
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0;

		// Token: 0x04007860 RID: 30816
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007861 RID: 30817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007862 RID: 30818
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007863 RID: 30819
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007864 RID: 30820
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007865 RID: 30821
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
