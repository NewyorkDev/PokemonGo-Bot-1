// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/GymFeedPokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GymFeedPokemonResponse.proto</summary>
  public static partial class GymFeedPokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/GymFeedPokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymFeedPokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0d5bUZlZWRQb2tl",
            "bW9uUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMaK1BPR09Qcm90b3MvRGF0YS9CYWRnZS9Bd2FyZGVkR3ltQmFkZ2Uu",
            "cHJvdG8aJlBPR09Qcm90b3MvRW51bXMvUG9rZW1vbkZhbWlseUlkLnByb3Rv",
            "Gi9QT0dPUHJvdG9zL0RhdGEvR3ltL0d5bVN0YXR1c0FuZERlZmVuZGVycy5w",
            "cm90byK+BQoWR3ltRmVlZFBva2Vtb25SZXNwb25zZRJOCgZyZXN1bHQYASAB",
            "KA4yPi5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkd5bUZlZWRQ",
            "b2tlbW9uUmVzcG9uc2UuUmVzdWx0EkwKGGd5bV9zdGF0dXNfYW5kX2RlZmVu",
            "ZGVycxgCIAEoCzIqLlBPR09Qcm90b3MuRGF0YS5HeW0uR3ltU3RhdHVzQW5k",
            "RGVmZW5kZXJzEkEKEWF3YXJkZWRfZ3ltX2JhZGdlGAMgASgLMiYuUE9HT1By",
            "b3Rvcy5EYXRhLkJhZGdlLkF3YXJkZWRHeW1CYWRnZRIYChBzdGFyZHVzdF9h",
            "d2FyZGVkGAQgASgFEhIKCnhwX2F3YXJkZWQYBSABKAUSGQoRbnVtX2NhbmR5",
            "X2F3YXJkZWQYBiABKAUSOgoPZmFtaWx5X2NhbmR5X2lkGAcgASgOMiEuUE9H",
            "T1Byb3Rvcy5FbnVtcy5Qb2tlbW9uRmFtaWx5SWQSGQoRY29vbGRvd25fY29t",
            "cGxldGUYCCABKAMiogIKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQ",
            "ARIUChBFUlJPUl9DQU5OT1RfVVNFEAISFgoSRVJST1JfTk9UX0lOX1JBTkdF",
            "EAMSGwoXRVJST1JfUE9LRU1PTl9OT1RfVEhFUkUQBBIWChJFUlJPUl9QT0tF",
            "TU9OX0ZVTEwQBRIZChVFUlJPUl9OT19CRVJSSUVTX0xFRlQQBhIUChBFUlJP",
            "Ul9XUk9OR19URUFNEAcSFQoRRVJST1JfV1JPTkdfQ09VTlQQCBISCg5FUlJP",
            "Ul9UT09fRkFTVBAJEhYKEkVSUk9SX1RPT19GUkVRVUVOVBAKEhIKDkVSUk9S",
            "X0dZTV9CVVNZEAsSFQoRRVJST1JfUkFJRF9BQ1RJVkUQDGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Badge.AwardedGymBadgeReflection.Descriptor, global::POGOProtos.Enums.PokemonFamilyIdReflection.Descriptor, global::POGOProtos.Data.Gym.GymStatusAndDefendersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.GymFeedPokemonResponse), global::POGOProtos.Networking.Responses.GymFeedPokemonResponse.Parser, new[]{ "Result", "GymStatusAndDefenders", "AwardedGymBadge", "StardustAwarded", "XpAwarded", "NumCandyAwarded", "FamilyCandyId", "CooldownComplete" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.GymFeedPokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymFeedPokemonResponse : pb::IMessage<GymFeedPokemonResponse> {
    private static readonly pb::MessageParser<GymFeedPokemonResponse> _parser = new pb::MessageParser<GymFeedPokemonResponse>(() => new GymFeedPokemonResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymFeedPokemonResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.GymFeedPokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymFeedPokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymFeedPokemonResponse(GymFeedPokemonResponse other) : this() {
      result_ = other.result_;
      GymStatusAndDefenders = other.gymStatusAndDefenders_ != null ? other.GymStatusAndDefenders.Clone() : null;
      AwardedGymBadge = other.awardedGymBadge_ != null ? other.AwardedGymBadge.Clone() : null;
      stardustAwarded_ = other.stardustAwarded_;
      xpAwarded_ = other.xpAwarded_;
      numCandyAwarded_ = other.numCandyAwarded_;
      familyCandyId_ = other.familyCandyId_;
      cooldownComplete_ = other.cooldownComplete_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymFeedPokemonResponse Clone() {
      return new GymFeedPokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.GymFeedPokemonResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.GymFeedPokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "gym_status_and_defenders" field.</summary>
    public const int GymStatusAndDefendersFieldNumber = 2;
    private global::POGOProtos.Data.Gym.GymStatusAndDefenders gymStatusAndDefenders_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Gym.GymStatusAndDefenders GymStatusAndDefenders {
      get { return gymStatusAndDefenders_; }
      set {
        gymStatusAndDefenders_ = value;
      }
    }

    /// <summary>Field number for the "awarded_gym_badge" field.</summary>
    public const int AwardedGymBadgeFieldNumber = 3;
    private global::POGOProtos.Data.Badge.AwardedGymBadge awardedGymBadge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Badge.AwardedGymBadge AwardedGymBadge {
      get { return awardedGymBadge_; }
      set {
        awardedGymBadge_ = value;
      }
    }

    /// <summary>Field number for the "stardust_awarded" field.</summary>
    public const int StardustAwardedFieldNumber = 4;
    private int stardustAwarded_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StardustAwarded {
      get { return stardustAwarded_; }
      set {
        stardustAwarded_ = value;
      }
    }

    /// <summary>Field number for the "xp_awarded" field.</summary>
    public const int XpAwardedFieldNumber = 5;
    private int xpAwarded_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int XpAwarded {
      get { return xpAwarded_; }
      set {
        xpAwarded_ = value;
      }
    }

    /// <summary>Field number for the "num_candy_awarded" field.</summary>
    public const int NumCandyAwardedFieldNumber = 6;
    private int numCandyAwarded_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumCandyAwarded {
      get { return numCandyAwarded_; }
      set {
        numCandyAwarded_ = value;
      }
    }

    /// <summary>Field number for the "family_candy_id" field.</summary>
    public const int FamilyCandyIdFieldNumber = 7;
    private global::POGOProtos.Enums.PokemonFamilyId familyCandyId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonFamilyId FamilyCandyId {
      get { return familyCandyId_; }
      set {
        familyCandyId_ = value;
      }
    }

    /// <summary>Field number for the "cooldown_complete" field.</summary>
    public const int CooldownCompleteFieldNumber = 8;
    private long cooldownComplete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CooldownComplete {
      get { return cooldownComplete_; }
      set {
        cooldownComplete_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymFeedPokemonResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymFeedPokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(GymStatusAndDefenders, other.GymStatusAndDefenders)) return false;
      if (!object.Equals(AwardedGymBadge, other.AwardedGymBadge)) return false;
      if (StardustAwarded != other.StardustAwarded) return false;
      if (XpAwarded != other.XpAwarded) return false;
      if (NumCandyAwarded != other.NumCandyAwarded) return false;
      if (FamilyCandyId != other.FamilyCandyId) return false;
      if (CooldownComplete != other.CooldownComplete) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (gymStatusAndDefenders_ != null) hash ^= GymStatusAndDefenders.GetHashCode();
      if (awardedGymBadge_ != null) hash ^= AwardedGymBadge.GetHashCode();
      if (StardustAwarded != 0) hash ^= StardustAwarded.GetHashCode();
      if (XpAwarded != 0) hash ^= XpAwarded.GetHashCode();
      if (NumCandyAwarded != 0) hash ^= NumCandyAwarded.GetHashCode();
      if (FamilyCandyId != 0) hash ^= FamilyCandyId.GetHashCode();
      if (CooldownComplete != 0L) hash ^= CooldownComplete.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (gymStatusAndDefenders_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GymStatusAndDefenders);
      }
      if (awardedGymBadge_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AwardedGymBadge);
      }
      if (StardustAwarded != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(StardustAwarded);
      }
      if (XpAwarded != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(XpAwarded);
      }
      if (NumCandyAwarded != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(NumCandyAwarded);
      }
      if (FamilyCandyId != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) FamilyCandyId);
      }
      if (CooldownComplete != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(CooldownComplete);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (gymStatusAndDefenders_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymStatusAndDefenders);
      }
      if (awardedGymBadge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AwardedGymBadge);
      }
      if (StardustAwarded != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StardustAwarded);
      }
      if (XpAwarded != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(XpAwarded);
      }
      if (NumCandyAwarded != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumCandyAwarded);
      }
      if (FamilyCandyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FamilyCandyId);
      }
      if (CooldownComplete != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownComplete);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymFeedPokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.gymStatusAndDefenders_ != null) {
        if (gymStatusAndDefenders_ == null) {
          gymStatusAndDefenders_ = new global::POGOProtos.Data.Gym.GymStatusAndDefenders();
        }
        GymStatusAndDefenders.MergeFrom(other.GymStatusAndDefenders);
      }
      if (other.awardedGymBadge_ != null) {
        if (awardedGymBadge_ == null) {
          awardedGymBadge_ = new global::POGOProtos.Data.Badge.AwardedGymBadge();
        }
        AwardedGymBadge.MergeFrom(other.AwardedGymBadge);
      }
      if (other.StardustAwarded != 0) {
        StardustAwarded = other.StardustAwarded;
      }
      if (other.XpAwarded != 0) {
        XpAwarded = other.XpAwarded;
      }
      if (other.NumCandyAwarded != 0) {
        NumCandyAwarded = other.NumCandyAwarded;
      }
      if (other.FamilyCandyId != 0) {
        FamilyCandyId = other.FamilyCandyId;
      }
      if (other.CooldownComplete != 0L) {
        CooldownComplete = other.CooldownComplete;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.GymFeedPokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (gymStatusAndDefenders_ == null) {
              gymStatusAndDefenders_ = new global::POGOProtos.Data.Gym.GymStatusAndDefenders();
            }
            input.ReadMessage(gymStatusAndDefenders_);
            break;
          }
          case 26: {
            if (awardedGymBadge_ == null) {
              awardedGymBadge_ = new global::POGOProtos.Data.Badge.AwardedGymBadge();
            }
            input.ReadMessage(awardedGymBadge_);
            break;
          }
          case 32: {
            StardustAwarded = input.ReadInt32();
            break;
          }
          case 40: {
            XpAwarded = input.ReadInt32();
            break;
          }
          case 48: {
            NumCandyAwarded = input.ReadInt32();
            break;
          }
          case 56: {
            familyCandyId_ = (global::POGOProtos.Enums.PokemonFamilyId) input.ReadEnum();
            break;
          }
          case 64: {
            CooldownComplete = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GymFeedPokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_CANNOT_USE")] ErrorCannotUse = 2,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 3,
        [pbr::OriginalName("ERROR_POKEMON_NOT_THERE")] ErrorPokemonNotThere = 4,
        [pbr::OriginalName("ERROR_POKEMON_FULL")] ErrorPokemonFull = 5,
        [pbr::OriginalName("ERROR_NO_BERRIES_LEFT")] ErrorNoBerriesLeft = 6,
        [pbr::OriginalName("ERROR_WRONG_TEAM")] ErrorWrongTeam = 7,
        [pbr::OriginalName("ERROR_WRONG_COUNT")] ErrorWrongCount = 8,
        [pbr::OriginalName("ERROR_TOO_FAST")] ErrorTooFast = 9,
        [pbr::OriginalName("ERROR_TOO_FREQUENT")] ErrorTooFrequent = 10,
        [pbr::OriginalName("ERROR_GYM_BUSY")] ErrorGymBusy = 11,
        [pbr::OriginalName("ERROR_RAID_ACTIVE")] ErrorRaidActive = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code