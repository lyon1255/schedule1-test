using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Variables;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200031F RID: 799
	public class Lily : NPC
	{
		// Token: 0x06003B43 RID: 15171 RVA: 0x0013119C File Offset: 0x0012F39C
		// Note: this type is marked as 'beforefieldinit'.
		static Lily()
		{
			Il2CppClassPointerStore<Lily>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Lily");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lily>.NativeClassPtr);
			Lily.NativeFieldInfoPtr_TutorialScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lily>.NativeClassPtr, "TutorialScheduleGroup");
			Lily.NativeFieldInfoPtr_RegularScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lily>.NativeClassPtr, "RegularScheduleGroup");
			Lily.NativeFieldInfoPtr_TutorialConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lily>.NativeClassPtr, "TutorialConditions");
			Lily.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lily>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted");
			Lily.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lily>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted");
			Lily.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670200);
			Lily.NativeMethodInfoPtr_Unlocked_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670201);
			Lily.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670202);
			Lily.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670203);
			Lily.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670204);
			Lily.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670205);
			Lily.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670206);
			Lily.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lily>.NativeClassPtr, 100670207);
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x001312D0 File Offset: 0x0012F4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142351, XrefRangeEnd = 142368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lily.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x0013130C File Offset: 0x0012F50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142368, XrefRangeEnd = 142377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unlocked(NPCRelationData.EUnlockType type, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lily.NativeMethodInfoPtr_Unlocked_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00131358 File Offset: 0x0012F558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142377, XrefRangeEnd = 142378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lily.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00131394 File Offset: 0x0012F594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lily() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lily>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lily.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x001313D0 File Offset: 0x0012F5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lily.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x0013140C File Offset: 0x0012F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lily.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00131448 File Offset: 0x0012F648
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lily.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x00131484 File Offset: 0x0012F684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142378, XrefRangeEnd = 142395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lily.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x0001E2C5 File Offset: 0x0001C4C5
		public Lily(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x001314C0 File Offset: 0x0012F6C0
		// (set) Token: 0x06003B4E RID: 15182 RVA: 0x0001E2CE File Offset: 0x0001C4CE
		public unsafe Transform TutorialScheduleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_TutorialScheduleGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_TutorialScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x001314F0 File Offset: 0x0012F6F0
		// (set) Token: 0x06003B50 RID: 15184 RVA: 0x0001E2ED File Offset: 0x0001C4ED
		public unsafe Transform RegularScheduleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_RegularScheduleGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_RegularScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06003B51 RID: 15185 RVA: 0x00131520 File Offset: 0x0012F720
		// (set) Token: 0x06003B52 RID: 15186 RVA: 0x0001E30C File Offset: 0x0001C50C
		public unsafe Conditions TutorialConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_TutorialConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_TutorialConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06003B53 RID: 15187 RVA: 0x00131550 File Offset: 0x0012F750
		// (set) Token: 0x06003B54 RID: 15188 RVA: 0x0001E32B File Offset: 0x0001C52B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x00131578 File Offset: 0x0012F778
		// (set) Token: 0x06003B56 RID: 15190 RVA: 0x0001E346 File Offset: 0x0001C546
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lily.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeFieldInfoPtr_TutorialScheduleGroup;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeFieldInfoPtr_RegularScheduleGroup;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeFieldInfoPtr_TutorialConditions;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr_Unlocked_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
