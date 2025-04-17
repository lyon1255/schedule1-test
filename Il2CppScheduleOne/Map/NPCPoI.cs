using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077F RID: 1919
	public class NPCPoI : POI
	{
		// Token: 0x0600B5B9 RID: 46521 RVA: 0x002D29D8 File Offset: 0x002D0BD8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPoI()
		{
			Il2CppClassPointerStore<NPCPoI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPoI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr);
			NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, "<NPC>k__BackingField");
			NPCPoI.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685635);
			NPCPoI.NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685636);
			NPCPoI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685637);
			NPCPoI.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685638);
			NPCPoI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100685639);
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600B5BA RID: 46522 RVA: 0x002D2A80 File Offset: 0x002D0C80
		// (set) Token: 0x0600B5BB RID: 46523 RVA: 0x002D2AC0 File Offset: 0x002D0CC0
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x002D2B04 File Offset: 0x002D0D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310325, XrefRangeEnd = 310340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPoI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x002D2B40 File Offset: 0x002D0D40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310355, RefRangeEnd = 310358, XrefRangeStart = 310340, XrefRangeEnd = 310355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x002D2B84 File Offset: 0x002D0D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310358, XrefRangeEnd = 310366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPoI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x00059318 File Offset: 0x00057518
		public NPCPoI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600B5C0 RID: 46528 RVA: 0x002D2BC0 File Offset: 0x002D0DC0
		// (set) Token: 0x0600B5C1 RID: 46529 RVA: 0x00059321 File Offset: 0x00057521
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A73 RID: 31347
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04007A74 RID: 31348
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04007A75 RID: 31349
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0;

		// Token: 0x04007A76 RID: 31350
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0;

		// Token: 0x04007A77 RID: 31351
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x04007A78 RID: 31352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
