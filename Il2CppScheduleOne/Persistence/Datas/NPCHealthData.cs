using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028A RID: 650
	public class NPCHealthData : SaveData
	{
		// Token: 0x0600301A RID: 12314 RVA: 0x00109578 File Offset: 0x00107778
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealthData()
		{
			Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCHealthData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr);
			NPCHealthData.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "Health");
			NPCHealthData.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "IsDead");
			NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, "DaysPassedSinceDeath");
			NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr, 100668799);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x001095F8 File Offset: 0x001077F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130610, RefRangeEnd = 130611, XrefRangeStart = 130610, XrefRangeEnd = 130611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealthData(float health, bool isDead, int daysPassedSinceDeath) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealthData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daysPassedSinceDeath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealthData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00019864 File Offset: 0x00017A64
		public NPCHealthData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x0010965C File Offset: 0x0010785C
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x0001986D File Offset: 0x00017A6D
		public unsafe float Health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_Health)) = value;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x00109684 File Offset: 0x00107884
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x00019888 File Offset: 0x00017A88
		public unsafe bool IsDead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_IsDead)) = value;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x001096AC File Offset: 0x001078AC
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x000198A3 File Offset: 0x00017AA3
		public unsafe int DaysPassedSinceDeath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealthData.NativeFieldInfoPtr_DaysPassedSinceDeath)) = value;
			}
		}

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeFieldInfoPtr_IsDead;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeFieldInfoPtr_DaysPassedSinceDeath;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_Int32_0;
	}
}
