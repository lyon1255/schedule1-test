using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.VoiceOver;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001F2 RID: 498
	public class Zombifying : Property
	{
		// Token: 0x06002875 RID: 10357 RVA: 0x000F052C File Offset: 0x000EE72C
		// Note: this type is marked as 'beforefieldinit'.
		static Zombifying()
		{
			Il2CppClassPointerStore<Zombifying>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Zombifying");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zombifying>.NativeClassPtr);
			Zombifying.NativeFieldInfoPtr_zombieVODatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zombifying>.NativeClassPtr, "zombieVODatabase");
			Zombifying.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zombifying>.NativeClassPtr, 100667861);
			Zombifying.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zombifying>.NativeClassPtr, 100667862);
			Zombifying.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zombifying>.NativeClassPtr, 100667863);
			Zombifying.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zombifying>.NativeClassPtr, 100667864);
			Zombifying.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zombifying>.NativeClassPtr, 100667865);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000F05D4 File Offset: 0x000EE7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118520, XrefRangeEnd = 118523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Zombifying.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000F0624 File Offset: 0x000EE824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118523, XrefRangeEnd = 118525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Zombifying.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000F0674 File Offset: 0x000EE874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118525, XrefRangeEnd = 118527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Zombifying.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000F06C4 File Offset: 0x000EE8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118527, XrefRangeEnd = 118529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Zombifying.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000F0714 File Offset: 0x000EE914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Zombifying() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zombifying>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zombifying.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00016003 File Offset: 0x00014203
		public Zombifying(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000F0750 File Offset: 0x000EE950
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0001600C File Offset: 0x0001420C
		public unsafe VODatabase zombieVODatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zombifying.NativeFieldInfoPtr_zombieVODatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zombifying.NativeFieldInfoPtr_zombieVODatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeFieldInfoPtr_zombieVODatabase;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
